#if !(PLATFORM_LUMIN && !UNITY_EDITOR)

#if !UNITY_WSA_10_0

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.DnnModule;
using OpenCVForUnity.ImgprocModule;
using OpenCVForUnity.ImgcodecsModule;
using OpenCVForUnity.UnityUtils;
using OpenCVForUnity.UnityUtils.Helper;
using NrealLightWithOpenCVForUnity.UnityUtils.Helper;
using NRKernal;
using OpenCVRect = OpenCVForUnity.CoreModule.Rect;
using OpenCVRange = OpenCVForUnity.CoreModule.Range;


namespace NrealLightWithOpenCVForUnityExample
{
    
    /// <summary>
    /// Nreal Yolo ObjectDetection
    /// Referring to https://github.com/opencv/opencv/blob/master/samples/dnn/object_detection.cpp.
    /// https://github.com/EnoxSoftware/NrealLightWithOpenCVForUnityExample/blob/master/Assets/NrealLightWithOpenCVForUnityExample/NrealDnnObjectDetectionExample/NrealDnnObjectDetectionExample.cs
    /// </summary>
    [RequireComponent(typeof(NRCamTextureToMatHelper))]
    public class NrealYoloObjectDetection : MonoBehaviour
    {

        [HeaderAttribute("YOLO")]
        
        [TooltipAttribute("Path to a binary file of model contains trained weights. It could be a file with extensions .caffemodel (Caffe), .pb (TensorFlow), .t7 or .net (Torch), .weights (Darknet).")]
        public string model = "yolov7-tiny.weights";

        [TooltipAttribute("Path to a text file of model contains network configuration. It could be a file with extensions .prototxt (Caffe), .pbtxt (TensorFlow), .cfg (Darknet).")]
        public string config = "yolov7-tiny.cfg";

        [TooltipAttribute("Optional path to a text file with names of classes to label detected objects.")]
        public string classes = "coco.names";

        [TooltipAttribute("Confidence threshold.")]
        public float confThreshold = 0.25f;

        [TooltipAttribute("Non-maximum suppression threshold.")]
        public float nmsThreshold = 0.45f;
        
        //[TooltipAttribute("Maximum detections per image.")]
        //public int topK = 1000;
        [TooltipAttribute("Preprocess input image by resizing to a specific width.")]
        public int inpWidth = 416;
        [TooltipAttribute("Preprocess input image by resizing to a specific height.")]
        public int inpHeight = 416;

        [Header("TEST")]
        
        [TooltipAttribute("Path to test input image.")]
        public string testInputImage;
        protected string classes_filepath;
        protected string config_filepath;
        protected string model_filepath;

        /// <summary>
        /// The texture.
        /// </summary>
        Texture2D texture;

        /// <summary>
        /// The webcam texture to mat helper.
        /// </summary>
        NRCamTextureToMatHelper webCamTextureToMatHelper;

        /// <summary>
        /// The image optimization helper.
        /// </summary>
        ImageOptimizationHelper imageOptimizationHelper;

        /// <summary>
        /// The bgr mat.
        /// </summary>
        Mat bgrMat;

        /// <summary>
        /// The YOLOv7 ObjectDetector.
        /// </summary>
        YOLOv7ObjectDetector objectDetector;

#if UNITY_WEBGL
        IEnumerator getFilePath_Coroutine;
#endif
        
        [HeaderAttribute("UI")]

        /// <summary>
        /// Determines if frame skip.
        /// </summary>
        public bool enableFrameSkip;

        /// <summary>
        /// The enable frame skip toggle.
        /// </summary>
        public Toggle enableFrameSkipToggle;

        /// <summary>
        /// Determines if displays camera image.
        /// </summary>
        public bool displayCameraImage = true;

        /// <summary>
        /// The display camera image toggle.
        /// </summary>
        public Toggle displayCameraImageToggle;

        /// <summary>
        /// the main camera.
        /// </summary>
        Camera mainCamera;

        /// <summary>
        /// The quad renderer.
        /// </summary>
        Renderer quad_renderer;

        //shows every 2nd frame
        bool show;

        //Popup stuff...
        [SerializeField] public ConfirmationPopup aConfirmationPopup;

        public bool showing = false; //Is a popup showing
        public int showingID;
        public int showingID2;
        List<string> classNames;

        public ShoppingListScrollView scrollViewInstance;





        // Use this for initialization
        void Start()
        {   
            enableFrameSkipToggle.isOn = enableFrameSkip;
            displayCameraImageToggle.isOn = displayCameraImage;
            // Get references to the required components
            imageOptimizationHelper = gameObject.GetComponent<ImageOptimizationHelper>();
            webCamTextureToMatHelper = gameObject.GetComponent<NRCamTextureToMatHelper>();
            
// Check if the application is running on WebGL platform
#if UNITY_WEBGL
            // If running on WebGL, start a coroutine to get file paths asynchronously
            getFilePath_Coroutine = GetFilePath();
            StartCoroutine(getFilePath_Coroutine);
#else
            // If not running on WebGL, check if the 'classes' file path is provided and exists
            if (!string.IsNullOrEmpty(classes))
            {
                // Get the file path for the 'classes' file
                classes_filepath = Utils.getFilePath("OpenCVForUnity/dnn/" + classes);
                
                // Check if the file path is empty, indicating that the file does not exist
                if (string.IsNullOrEmpty(classes_filepath)) Debug.Log("The file:" + classes + " did not exist in the folder “Assets/StreamingAssets/OpenCVForUnity/dnn”.");
            }
            // Check if the 'config' file path is provided and exists
            if (!string.IsNullOrEmpty(config))
            {
                // Get the file path for the 'config' file
                config_filepath = Utils.getFilePath("OpenCVForUnity/dnn/" + config);
                
                // Check if the file path is empty, indicating that the file does not exist
                if (string.IsNullOrEmpty(config_filepath)) Debug.Log("The file:" + config + " did not exist in the folder “Assets/StreamingAssets/OpenCVForUnity/dnn”.");
            }
            // Check if the 'model' file path is provided and exists
            if (!string.IsNullOrEmpty(model))
            {
                // Get the file path for the 'model' file
                model_filepath = Utils.getFilePath("OpenCVForUnity/dnn/" + model);
                
                // Check if the file path is empty, indicating that the file does not exist
                if (string.IsNullOrEmpty(model_filepath)) Debug.Log("The file:" + model + " did not exist in the folder “Assets/StreamingAssets/OpenCVForUnity/dnn”.");
            }
            
            // Run the application
            Run();
#endif
        }

#if UNITY_WEBGL
        // This method is a coroutine that retrieves file paths asynchronously in WebGL platform
        private virtual IEnumerator GetFilePath()
        {
            // Check if the 'classes' file path is provided and exists
            if (!string.IsNullOrEmpty(classes))
            {
                // Start a coroutine to get the file path for the 'classes' file asynchronously
                var getFilePathAsync_0_Coroutine = Utils.getFilePathAsync("OpenCVForUnity/dnn/" + classes, (result) =>
                {
                    classes_filepath = result;
                });
                yield return getFilePathAsync_0_Coroutine;

                // Check if the file path is empty, indicating that the file does not exist
                if (string.IsNullOrEmpty(classes_filepath)) Debug.Log("The file:" + classes + " did not exist in the folder “Assets/StreamingAssets/OpenCVForUnity/dnn”.");
            }

            // Similar operations are performed for the 'config' and 'model' file paths
            if (!string.IsNullOrEmpty(config))
            {
                var getFilePathAsync_1_Coroutine = Utils.getFilePathAsync("OpenCVForUnity/dnn/" + config, (result) =>
                {
                    config_filepath = result;
                });
                yield return getFilePathAsync_1_Coroutine;

                if (string.IsNullOrEmpty(config_filepath)) Debug.Log("The file:" + config + " did not exist in the folder “Assets/StreamingAssets/OpenCVForUnity/dnn”.");
            }

            if (!string.IsNullOrEmpty(model))
            {
                var getFilePathAsync_2_Coroutine = Utils.getFilePathAsync("OpenCVForUnity/dnn/" + model, (result) =>
                {
                    model_filepath = result;
                });
                yield return getFilePathAsync_2_Coroutine;

                if (string.IsNullOrEmpty(model_filepath)) Debug.Log("The file:" + model + " did not exist in the folder “Assets/StreamingAssets/OpenCVForUnity/dnn”.");
            }

            // Set the getFilePath_Coroutine variable to null (coroutine has completed)
            getFilePath_Coroutine = null;

            // Run the application
            Run();
        }
#endif

        // This method is responsible for running the object detection application
        void Run()
        {
            // Set the debug mode for OpenCV to display error logs
            Utils.setDebugMode(true);

            // Check if the 'model' and 'classes' file paths are provided
            if (string.IsNullOrEmpty(model_filepath) || string.IsNullOrEmpty(classes_filepath))
            {
                Debug.LogError("model: " + model + " or " + "config: " + config + " or " + "classes: " + classes + " is not loaded.");
            }
            else
            {
                // Create an instance of the YOLOv7ObjectDetector using the provided file paths
                objectDetector = new YOLOv7ObjectDetector(model_filepath, config_filepath, classes_filepath, new Size(inpWidth, inpHeight), confThreshold, nmsThreshold/*, topK*/);
                classNames = readClassNames(classes_filepath);
            }

            // Check if a test input image is provided
            if (string.IsNullOrEmpty(testInputImage))
            {
            // If no test input image is provided, initialize the web camera texture to mat helper
			webCamTextureToMatHelper.outputColorFormat = WebCamTextureToMatHelper.ColorFormat.RGB;
            webCamTextureToMatHelper.Initialize();
            }
            
            // If a test input image is provided, load the image and perform object detection on it
            else
            {

                // Start a coroutine to get the file path for the test input image asynchronously
                var getFilePathAsync_0_Coroutine = Utils.getFilePathAsync("OpenCVForUnity/dnn/" + testInputImage, (result) =>
                {
                    string test_input_image_filepath = result;
                    if (string.IsNullOrEmpty(test_input_image_filepath)) Debug.Log("The file:" + testInputImage + " did not exist in the folder “Assets/StreamingAssets/OpenCVForUnity/dnn”.");
                    Mat img = Imgcodecs.imread(test_input_image_filepath);
                    // Perform object detection and visualization on the image
                    if (img.empty())
                    {
                        img = new Mat(424, 640, CvType.CV_8UC3, new Scalar(0, 0, 0));
                        Imgproc.putText(img, testInputImage + " is not loaded.", new Point(5, img.rows() - 30), Imgproc.FONT_HERSHEY_SIMPLEX, 0.7, new Scalar(255, 255, 255, 255), 2, Imgproc.LINE_AA, false);
                        Imgproc.putText(img, "Please read console message.", new Point(5, img.rows() - 10), Imgproc.FONT_HERSHEY_SIMPLEX, 0.7, new Scalar(255, 255, 255, 255), 2, Imgproc.LINE_AA, false);
                    }
                    else
                    {
                        //TickMeter tm = new TickMeter();
                        //tm.start();
                        Mat results = objectDetector.infer(img);
                        //tm.stop();
                        //Debug.Log("YOLOv7ObjectDetector Inference time (preprocess + infer + postprocess), ms: " + tm.getTimeMilli());
                        
                        showingID = objectDetector.visualize(img, results, true, false);
                    }
                    gameObject.transform.localScale = new Vector3(img.width(), img.height(), 1);
                    float imageWidth = img.width();
                    float imageHeight = img.height();
                    float widthScale = (float)Screen.width / imageWidth;
                    float heightScale = (float)Screen.height / imageHeight;
                    if (widthScale < heightScale)
                    {
                        Camera.main.orthographicSize = (imageWidth * (float)Screen.height / (float)Screen.width) / 2;
                    }
                    else
                    {
                        Camera.main.orthographicSize = imageHeight / 2;
                    }
                    
                    Imgproc.cvtColor(img, img, Imgproc.COLOR_BGR2RGB);
                    Texture2D texture = new Texture2D(img.cols(), img.rows(), TextureFormat.RGB24, false);
                    Utils.matToTexture2D(img, texture);
                    gameObject.GetComponent<Renderer>().material.mainTexture = texture;
                });
                StartCoroutine(getFilePathAsync_0_Coroutine);

                /////////////////////
            }
        }

        /// <summary>
        /// Raises the webcam texture to mat helper initialized event.
        /// This method is called when the web camera texture to mat helper is initialized
        /// </summary>
        public void OnWebCamTextureToMatHelperInitialized()
        {
            Debug.Log("OnWebCamTextureToMatHelperInitialized");

            // Get the current frame from the web camera texture to mat helper
            Mat webCamTextureMat = webCamTextureToMatHelper.GetMat();
            
            // Create a new Texture2D with the dimensions of the web camera texture
            texture = new Texture2D(webCamTextureMat.cols(), webCamTextureMat.rows(), TextureFormat.RGB24, false);
            
            // Convert the web camera texture mat to a Texture2D
            Utils.matToTexture2D(webCamTextureMat, texture);
            
            // Set the main texture of the renderer's material to the converted Texture2D
            gameObject.GetComponent<Renderer>().material.mainTexture = texture;

            // Get the Renderer component and set the necessary parameters for the shader
            quad_renderer = gameObject.GetComponent<Renderer>() as Renderer;
            quad_renderer.sharedMaterial.SetTexture("_MainTex", texture);
            quad_renderer.sharedMaterial.SetVector("_VignetteOffset", new Vector4(0, 0));
            quad_renderer.sharedMaterial.SetFloat("_VignetteScale", 0.0f);
            
// Set the camera projection matrix based on the platform (WebGL or Unity Editor)
#if !UNITY_EDITOR
            quad_renderer.sharedMaterial.SetMatrix("_CameraProjectionMatrix", webCamTextureToMatHelper.GetProjectionMatrix());
#else
            mainCamera = NRSessionManager.Instance.NRHMDPoseTracker.centerCamera;
            quad_renderer.sharedMaterial.SetMatrix("_CameraProjectionMatrix", mainCamera.projectionMatrix);
#endif
            // Create a new Mat with the dimensions of the web camera texture
            bgrMat = new Mat(webCamTextureMat.rows(), webCamTextureMat.cols(), CvType.CV_8UC3);
        }

        /// <summary>
        /// Raises the webcam texture to mat helper disposed event.
        /// This method is called when the web camera texture to mat helper is disposed
        /// </summary>
        public void OnWebCamTextureToMatHelperDisposed()
        {
            Debug.Log("OnWebCamTextureToMatHelperDisposed");

            // Dispose the bgrMat if it exists
            if (bgrMat != null)
                bgrMat.Dispose();

            // Destroy the texture if it exists
            if (texture != null)
            {
                Texture2D.Destroy(texture);
                texture = null;
            }
        }

        /// <summary>
        /// Raises the webcam texture to mat helper error occurred event.
        /// This method is called when an error occurs in the web camera texture to mat helper
        /// </summary>
        /// <param name="errorCode">Error code.</param>
        public void OnWebCamTextureToMatHelperErrorOccurred(WebCamTextureToMatHelper.ErrorCode errorCode)
        {
            Debug.Log("OnWebCamTextureToMatHelperErrorOccurred " + errorCode);
        }

        // Update is called once per frame
        void Update()
        {   
            show=!show;
            if(show){
                return;
            }

            // Check if the web camera texture to mat helper is playing and if the frame was updated
            if (webCamTextureToMatHelper.IsPlaying() && webCamTextureToMatHelper.DidUpdateThisFrame())
            {
                // If frame skipping is enabled and the current frame should be skipped, return
                if (enableFrameSkip && imageOptimizationHelper.IsCurrentFrameSkipped())
                    return;
                
                // Get the current frame from the web camera texture to mat helper
                Mat rgb = webCamTextureToMatHelper.GetMat();

                // Check if the object detector is null
                if (objectDetector == null)
                {
                    //If the object detector is null, you can add some text overlays to the frame using Imgproc.putText() to indicate that the model file is not loaded or to read console messages.
                    //Imgproc.putText(rgbMat, "model file is not loaded.", new Point(5, rgbMat.rows() - 30), Imgproc.FONT_HERSHEY_SIMPLEX, 0.7, new Scalar(255, 255, 255, 255), 2, Imgproc.LINE_AA, false);
                    //Imgproc.putText(rgbMat, "Please read console message.", new Point(5, rgbMat.rows() - 10), Imgproc.FONT_HERSHEY_SIMPLEX, 0.7, new Scalar(255, 255, 255, 255), 2, Imgproc.LINE_AA, false);
                }
                else
                {


                    // Convert the image from RGB to BGR color space
                    Imgproc.cvtColor(rgb, bgrMat, Imgproc.COLOR_RGB2BGR); //converting image from rgb to bgr 

                    // Create an input blob for the object detector using the BGR image
                    
                    Size inpSize = new Size(320,320);
                    Mat rgbMat = Dnn.blobFromImage(bgrMat, 1.0f, inpSize, new Scalar(0, 0, 0, 0), false, false);

                    //TickMeter tm = new TickMeter();
                    //tm.start();

                    // Perform inference using the object detector
                    Mat results = objectDetector.infer(bgrMat);
                    
                    //tm.stop();
                    //Debug.Log("YOLOv7ObjectDetector Inference time (preprocess + infer + postprocess), ms: " + tm.getTimeMilli());
                    
                    
                    Imgproc.cvtColor(bgrMat, rgbMat, Imgproc.COLOR_BGR2RGBA);
                    
                    // Visualize the results on the RGB image
                    //Debug.Log(taken[4]);
                    if (!displayCameraImage){
                        Mat blankMat = new Mat(rgbMat.rows(), rgbMat.cols(), CvType.CV_8UC3, new Scalar(0, 0, 0));
                        showingID2 = objectDetector.visualize(blankMat, results, false, true); //rgbmat
                    
                        // Convert the RGB image with visualized results to a Texture2D
                        Utils.matToTexture2D(blankMat, texture);
                    }
                    else{
                        showingID2 = objectDetector.visualize(rgbMat, results, false, true); //rgbmat

                        

                        // Convert the RGB image with visualized results to a Texture2D
                        Utils.matToTexture2D(rgbMat, texture);
                    }
                    
                    if(!showing && showingID2!=-1){
                        OpenConfirmationWindow(classNames[showingID2]);
                        showingID = showingID2;
                    }



                }
            }
            // Check if the web camera texture to mat helper is playing
            if (webCamTextureToMatHelper.IsPlaying())
            { 
                
// Get the camera to world matrix
#if UNITY_ANDROID && !UNITY_EDITOR
                Matrix4x4 cameraToWorldMatrix = webCamTextureToMatHelper.GetCameraToWorldMatrix();
#else
                Matrix4x4 cameraToWorldMatrix = mainCamera.cameraToWorldMatrix;
#endif
                // Calculate the world to camera matrix
                Matrix4x4 worldToCameraMatrix = cameraToWorldMatrix.inverse;
                
                // Set the world to camera matrix in the shared material of the renderer
                quad_renderer.sharedMaterial.SetMatrix("_WorldToCameraMatrix", worldToCameraMatrix);

                // Uncomment this section if you want to adjust the position and rotation of the canvas object
                /*
                // Position the canvas object slightly in front
                // of the real world web camera.
                Vector3 position = cameraToWorldMatrix.GetColumn(3) - cameraToWorldMatrix.GetColumn(2);
                position *= 1.5f;

                // Rotate the canvas object so that it faces the user.
                Quaternion rotation = Quaternion.LookRotation(-cameraToWorldMatrix.GetColumn(2), cameraToWorldMatrix.GetColumn(1));

                gameObject.transform.position = position;
                gameObject.transform.rotation = rotation;
                */

                //
                // Adjusting the position and scale of the display screen
                // to counteract the phenomenon of texture margins (transparent areas in MR space) being displayed as black when recording video using NRVideoCapture.
                //
                // Position the canvas object slightly in front
                // of the real world web camera.
                
                // Define the distance for overlaying the canvas object in front of the real-world web camera
                float overlayDistance = 1.5f;
                
                // Calculate the camera space position for the center of the canvas object
                Vector3 ccCameraSpacePos = UnProjectVector(webCamTextureToMatHelper.GetProjectionMatrix(), new Vector3(0.0f, 0.0f, overlayDistance));
                
                // Calculate the camera space position for the top-left corner of the canvas object
                Vector3 tlCameraSpacePos = UnProjectVector(webCamTextureToMatHelper.GetProjectionMatrix(), new Vector3(-overlayDistance, overlayDistance, overlayDistance));

                // Convert the camera space position of the center of the canvas object to world space
                Vector3 position = cameraToWorldMatrix.MultiplyPoint3x4(ccCameraSpacePos);
                
                // Set the position of the canvas object
                gameObject.transform.position = position;

                // Calculate the scale of the canvas object based on the difference in camera space positions between the top-left corner and center
                Vector3 scale = new Vector3(Mathf.Abs(tlCameraSpacePos.x - ccCameraSpacePos.x) * 2, Mathf.Abs(tlCameraSpacePos.y - ccCameraSpacePos.y) * 2, 1);
                
                // Set the scale of the canvas object
                gameObject.transform.localScale = scale;

                // Rotate the canvas object so that it faces the user.
                Quaternion rotation = Quaternion.LookRotation(-cameraToWorldMatrix.GetColumn(2), cameraToWorldMatrix.GetColumn(1));
                gameObject.transform.rotation = rotation;
            }
        }
        
        /// <summary>
        /// Converts a vector from screen space to camera space using the provided projection matrix.
        /// </summary>
        /// <param name="proj">The projection matrix used for the conversion.</param>
        /// <param name="to">The vector to be converted.</param>
        /// <returns>The vector in camera space.</returns>
        private Vector3 UnProjectVector(Matrix4x4 proj, Vector3 to)
        {
            Vector3 from = new Vector3(0, 0, 0);
            var axsX = proj.GetRow(0);
            var axsY = proj.GetRow(1);
            var axsZ = proj.GetRow(2);
            from.z = to.z / axsZ.z;
            from.y = (to.y - (from.z * axsY.z)) / axsY.y;
            from.x = (to.x - (from.z * axsX.z)) / axsX.x;
            return from;
        }

        /// <summary>
        /// Raises the destroy event.
        /// </summary>
        void OnDestroy()
        {
            // Dispose the webCamTextureToMatHelper
            webCamTextureToMatHelper.Dispose();
            
            // Dispose the imageOptimizationHelper
            imageOptimizationHelper.Dispose();

            // Dispose the objectDetector if it is not null
            if (objectDetector != null)
                objectDetector.dispose();

            // Disable the debug mode in the Utils class
            Utils.setDebugMode(false);

// Dispose the getFilePath_Coroutine if it is running
#if UNITY_WEBGL
            if (getFilePath_Coroutine != null)
            {
                StopCoroutine(getFilePath_Coroutine);
                ((IDisposable)getFilePath_Coroutine).Dispose();
            }
#endif
        }

        /// <summary>
        /// Raises the back button click event.
        /// </summary>
        public void OnBackButtonClick()
        {
            SceneManager.LoadScene("NrealLightWithOpenCVForUnityExample");
        }

        /// <summary>
        /// Raises the play button click event.
        /// </summary>
        public void OnPlayButtonClick()
        {
            webCamTextureToMatHelper.Play();
        }

        /// <summary>
        /// Raises the pause button click event.
        /// </summary>
        public void OnPauseButtonClick()
        {
            webCamTextureToMatHelper.Pause();
        }

        /// <summary>
        /// Raises the stop button click event.
        /// </summary>
        public void OnStopButtonClick()
        {
            webCamTextureToMatHelper.Stop();
        }

        /// <summary>
        /// Raises the change camera button click event.
        /// </summary>
        public void OnChangeCameraButtonClick()
        {
            webCamTextureToMatHelper.requestedIsFrontFacing = !webCamTextureToMatHelper.requestedIsFrontFacing;
        }

        /// <summary>
        /// Checks if a given integer value exists in the phoneBook array.
        /// </summary>
        /// <param name="i">The integer value to check.</param>
        /// <returns>True if the value exists in the phoneBook array, false otherwise.</returns>
		public bool checkClass(int i){
            //return taken[i];
            //int[] phoneBook = {67, 73};
            //return Array.Exists(phoneBook, element=>element==i);
            return true; 
        }

        /// <summary>
        /// Returns a string representing the quantity based on the given integer value.
        /// </summary>
        /// <param name="i">The integer value.</param>
        /// <returns>A string representing the quantity.</returns>

        public static string getQuant(int i){
            return "Quant: X"+i.ToString();
        }
        
        /// <summary>
        /// Raises the enable frame skip toggle value changed event.
        /// </summary>
        public void OnEnableFrameSkipToggleValueChanged()
        {
            enableFrameSkip = enableFrameSkipToggle.isOn;
        }

        /// <summary>
        /// Raises the display camera image toggle value changed event.
        /// </summary>
        public void OnDisplayCameraImageToggleValueChanged()
        {
            displayCameraImage = displayCameraImageToggle.isOn;
        }

        private void OpenConfirmationWindow(string message){
            showing=true;
            aConfirmationPopup.gameObject.SetActive(true);
            aConfirmationPopup.confirmButton.onClick.AddListener(ConfirmClicked);
            aConfirmationPopup.noButton.onClick.AddListener(NoClicked);
            aConfirmationPopup.messageText.text = message + " has been identified! Is the identified item correct?";
        }

        public void ConfirmClicked(){
            aConfirmationPopup.gameObject.SetActive(false);
            aConfirmationPopup.confirmButton.onClick.RemoveListener(ConfirmClicked);
            aConfirmationPopup.noButton.onClick.RemoveListener(NoClicked);

            scrollViewInstance.itemMatching();
            objectDetector.showing(showingID);
            showing=false;
        }

        public void NoClicked(){
            aConfirmationPopup.gameObject.SetActive(false);
            aConfirmationPopup.confirmButton.onClick.RemoveListener(ConfirmClicked);
            aConfirmationPopup.noButton.onClick.RemoveListener(NoClicked);

            showing=false;

        }

        protected virtual List<string> readClassNames(string filename)
            {
            
                List<string> classNames = new List<string>();

                System.IO.StreamReader cReader = null;
                try
                {
                    cReader = new System.IO.StreamReader(filename, System.Text.Encoding.Default);

                    while (cReader.Peek() >= 0)
                    {
                        string name = cReader.ReadLine();
                        classNames.Add(name);
                    }
                }
                catch (System.Exception ex)
                {
                    Debug.LogError(ex.Message);
                    return null;
                }
                finally
                {
                    if (cReader != null)
                        cReader.Close();
                }

                return classNames;
            }




    }
    
}
#endif

#endif
