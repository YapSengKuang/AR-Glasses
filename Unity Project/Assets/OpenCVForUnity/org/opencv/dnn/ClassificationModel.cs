#if !UNITY_WSA_10_0

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.DnnModule
{

    // C++: class ClassificationModel
    /**
     * This class represents high-level API for classification models.
     *
     * ClassificationModel allows to set params for preprocessing input image.
     * ClassificationModel creates net from file with trained weights and config,
     * sets preprocessing input, runs forward pass and return top-1 prediction.
     */

    public class ClassificationModel : Model
    {

        protected override void Dispose(bool disposing)
        {

            try
            {
                if (disposing)
                {
                }
                if (IsEnabledDispose)
                {
                    if (nativeObj != IntPtr.Zero)
                        dnn_ClassificationModel_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal ClassificationModel(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new ClassificationModel __fromPtr__(IntPtr addr) { return new ClassificationModel(addr); }

        //
        // C++:   cv::dnn::ClassificationModel::ClassificationModel(String model, String config = "")
        //

        /**
         * Create classification model from network represented in one of the supported formats.
         * An order of {code model} and {code config} arguments does not matter.
         * param model Binary file contains trained weights.
         * param config Text file contains network configuration.
         */
        public ClassificationModel(string model, string config) :
            base(DisposableObject.ThrowIfNullIntPtr(dnn_ClassificationModel_ClassificationModel_10(model, config)))
        {



        }

        /**
         * Create classification model from network represented in one of the supported formats.
         * An order of {code model} and {code config} arguments does not matter.
         * param model Binary file contains trained weights.
         */
        public ClassificationModel(string model) :
            base(DisposableObject.ThrowIfNullIntPtr(dnn_ClassificationModel_ClassificationModel_11(model)))
        {



        }


        //
        // C++:   cv::dnn::ClassificationModel::ClassificationModel(Net network)
        //

        /**
         * Create model from deep learning network.
         * param network Net object.
         */
        public ClassificationModel(Net network) :
            base(DisposableObject.ThrowIfNullIntPtr(dnn_ClassificationModel_ClassificationModel_12(network.nativeObj)))
        {



        }


        //
        // C++:  void cv::dnn::ClassificationModel::classify(Mat frame, int& classId, float& conf)
        //

        public void classify(Mat frame, int[] classId, float[] conf)
        {
            ThrowIfDisposed();
            if (frame != null) frame.ThrowIfDisposed();
            double[] classId_out = new double[1];
            double[] conf_out = new double[1];
            dnn_ClassificationModel_classify_10(nativeObj, frame.nativeObj, classId_out, conf_out);
            if (classId != null) classId[0] = (int)classId_out[0];
            if (conf != null) conf[0] = (float)conf_out[0];

        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::dnn::ClassificationModel::ClassificationModel(String model, String config = "")
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_ClassificationModel_ClassificationModel_10(string model, string config);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_ClassificationModel_ClassificationModel_11(string model);

        // C++:   cv::dnn::ClassificationModel::ClassificationModel(Net network)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_ClassificationModel_ClassificationModel_12(IntPtr network_nativeObj);

        // C++:  void cv::dnn::ClassificationModel::classify(Mat frame, int& classId, float& conf)
        [DllImport(LIBNAME)]
        private static extern void dnn_ClassificationModel_classify_10(IntPtr nativeObj, IntPtr frame_nativeObj, double[] classId_out, double[] conf_out);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void dnn_ClassificationModel_delete(IntPtr nativeObj);

    }
}
#endif