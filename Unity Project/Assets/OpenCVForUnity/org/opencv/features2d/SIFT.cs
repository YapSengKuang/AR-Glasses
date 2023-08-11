
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{

    // C++: class SIFT
    /**
     * Class for extracting keypoints and computing descriptors using the Scale Invariant Feature Transform
     * (SIFT) algorithm by D. Lowe CITE: Lowe04 .
     */

    public class SIFT : Feature2D
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
                        features2d_SIFT_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal SIFT(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new SIFT __fromPtr__(IntPtr addr) { return new SIFT(addr); }

        //
        // C++: static Ptr_SIFT cv::SIFT::create(int nfeatures = 0, int nOctaveLayers = 3, double contrastThreshold = 0.04, double edgeThreshold = 10, double sigma = 1.6)
        //

        /**
         * param nfeatures The number of best features to retain. The features are ranked by their scores
         *     (measured in SIFT algorithm as the local contrast)
         *
         *     param nOctaveLayers The number of layers in each octave. 3 is the value used in D. Lowe paper. The
         *     number of octaves is computed automatically from the image resolution.
         *
         *     param contrastThreshold The contrast threshold used to filter out weak features in semi-uniform
         *     (low-contrast) regions. The larger the threshold, the less features are produced by the detector.
         *
         *     <b>Note:</b> The contrast threshold will be divided by nOctaveLayers when the filtering is applied. When
         *     nOctaveLayers is set to default and if you want to use the value used in D. Lowe paper, 0.03, set
         *     this argument to 0.09.
         *
         *     param edgeThreshold The threshold used to filter out edge-like features. Note that the its meaning
         *     is different from the contrastThreshold, i.e. the larger the edgeThreshold, the less features are
         *     filtered out (more features are retained).
         *
         *     param sigma The sigma of the Gaussian applied to the input image at the octave \#0. If your image
         *     is captured with a weak camera with soft lenses, you might want to reduce the number.
         * return automatically generated
         */
        public static SIFT create(int nfeatures, int nOctaveLayers, double contrastThreshold, double edgeThreshold, double sigma)
        {


            return SIFT.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_SIFT_create_10(nfeatures, nOctaveLayers, contrastThreshold, edgeThreshold, sigma)));


        }

        /**
         * param nfeatures The number of best features to retain. The features are ranked by their scores
         *     (measured in SIFT algorithm as the local contrast)
         *
         *     param nOctaveLayers The number of layers in each octave. 3 is the value used in D. Lowe paper. The
         *     number of octaves is computed automatically from the image resolution.
         *
         *     param contrastThreshold The contrast threshold used to filter out weak features in semi-uniform
         *     (low-contrast) regions. The larger the threshold, the less features are produced by the detector.
         *
         *     <b>Note:</b> The contrast threshold will be divided by nOctaveLayers when the filtering is applied. When
         *     nOctaveLayers is set to default and if you want to use the value used in D. Lowe paper, 0.03, set
         *     this argument to 0.09.
         *
         *     param edgeThreshold The threshold used to filter out edge-like features. Note that the its meaning
         *     is different from the contrastThreshold, i.e. the larger the edgeThreshold, the less features are
         *     filtered out (more features are retained).
         *
         *     is captured with a weak camera with soft lenses, you might want to reduce the number.
         * return automatically generated
         */
        public static SIFT create(int nfeatures, int nOctaveLayers, double contrastThreshold, double edgeThreshold)
        {


            return SIFT.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_SIFT_create_11(nfeatures, nOctaveLayers, contrastThreshold, edgeThreshold)));


        }

        /**
         * param nfeatures The number of best features to retain. The features are ranked by their scores
         *     (measured in SIFT algorithm as the local contrast)
         *
         *     param nOctaveLayers The number of layers in each octave. 3 is the value used in D. Lowe paper. The
         *     number of octaves is computed automatically from the image resolution.
         *
         *     param contrastThreshold The contrast threshold used to filter out weak features in semi-uniform
         *     (low-contrast) regions. The larger the threshold, the less features are produced by the detector.
         *
         *     <b>Note:</b> The contrast threshold will be divided by nOctaveLayers when the filtering is applied. When
         *     nOctaveLayers is set to default and if you want to use the value used in D. Lowe paper, 0.03, set
         *     this argument to 0.09.
         *
         *     is different from the contrastThreshold, i.e. the larger the edgeThreshold, the less features are
         *     filtered out (more features are retained).
         *
         *     is captured with a weak camera with soft lenses, you might want to reduce the number.
         * return automatically generated
         */
        public static SIFT create(int nfeatures, int nOctaveLayers, double contrastThreshold)
        {


            return SIFT.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_SIFT_create_12(nfeatures, nOctaveLayers, contrastThreshold)));


        }

        /**
         * param nfeatures The number of best features to retain. The features are ranked by their scores
         *     (measured in SIFT algorithm as the local contrast)
         *
         *     param nOctaveLayers The number of layers in each octave. 3 is the value used in D. Lowe paper. The
         *     number of octaves is computed automatically from the image resolution.
         *
         *     (low-contrast) regions. The larger the threshold, the less features are produced by the detector.
         *
         *     <b>Note:</b> The contrast threshold will be divided by nOctaveLayers when the filtering is applied. When
         *     nOctaveLayers is set to default and if you want to use the value used in D. Lowe paper, 0.03, set
         *     this argument to 0.09.
         *
         *     is different from the contrastThreshold, i.e. the larger the edgeThreshold, the less features are
         *     filtered out (more features are retained).
         *
         *     is captured with a weak camera with soft lenses, you might want to reduce the number.
         * return automatically generated
         */
        public static SIFT create(int nfeatures, int nOctaveLayers)
        {


            return SIFT.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_SIFT_create_13(nfeatures, nOctaveLayers)));


        }

        /**
         * param nfeatures The number of best features to retain. The features are ranked by their scores
         *     (measured in SIFT algorithm as the local contrast)
         *
         *     number of octaves is computed automatically from the image resolution.
         *
         *     (low-contrast) regions. The larger the threshold, the less features are produced by the detector.
         *
         *     <b>Note:</b> The contrast threshold will be divided by nOctaveLayers when the filtering is applied. When
         *     nOctaveLayers is set to default and if you want to use the value used in D. Lowe paper, 0.03, set
         *     this argument to 0.09.
         *
         *     is different from the contrastThreshold, i.e. the larger the edgeThreshold, the less features are
         *     filtered out (more features are retained).
         *
         *     is captured with a weak camera with soft lenses, you might want to reduce the number.
         * return automatically generated
         */
        public static SIFT create(int nfeatures)
        {


            return SIFT.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_SIFT_create_14(nfeatures)));


        }

        /**
         *     (measured in SIFT algorithm as the local contrast)
         *
         *     number of octaves is computed automatically from the image resolution.
         *
         *     (low-contrast) regions. The larger the threshold, the less features are produced by the detector.
         *
         *     <b>Note:</b> The contrast threshold will be divided by nOctaveLayers when the filtering is applied. When
         *     nOctaveLayers is set to default and if you want to use the value used in D. Lowe paper, 0.03, set
         *     this argument to 0.09.
         *
         *     is different from the contrastThreshold, i.e. the larger the edgeThreshold, the less features are
         *     filtered out (more features are retained).
         *
         *     is captured with a weak camera with soft lenses, you might want to reduce the number.
         * return automatically generated
         */
        public static SIFT create()
        {


            return SIFT.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_SIFT_create_15()));


        }


        //
        // C++: static Ptr_SIFT cv::SIFT::create(int nfeatures, int nOctaveLayers, double contrastThreshold, double edgeThreshold, double sigma, int descriptorType)
        //

        /**
         * Create SIFT with specified descriptorType.
         *     param nfeatures The number of best features to retain. The features are ranked by their scores
         *     (measured in SIFT algorithm as the local contrast)
         *
         *     param nOctaveLayers The number of layers in each octave. 3 is the value used in D. Lowe paper. The
         *     number of octaves is computed automatically from the image resolution.
         *
         *     param contrastThreshold The contrast threshold used to filter out weak features in semi-uniform
         *     (low-contrast) regions. The larger the threshold, the less features are produced by the detector.
         *
         *     <b>Note:</b> The contrast threshold will be divided by nOctaveLayers when the filtering is applied. When
         *     nOctaveLayers is set to default and if you want to use the value used in D. Lowe paper, 0.03, set
         *     this argument to 0.09.
         *
         *     param edgeThreshold The threshold used to filter out edge-like features. Note that the its meaning
         *     is different from the contrastThreshold, i.e. the larger the edgeThreshold, the less features are
         *     filtered out (more features are retained).
         *
         *     param sigma The sigma of the Gaussian applied to the input image at the octave \#0. If your image
         *     is captured with a weak camera with soft lenses, you might want to reduce the number.
         *
         *     param descriptorType The type of descriptors. Only CV_32F and CV_8U are supported.
         * return automatically generated
         */
        public static SIFT create(int nfeatures, int nOctaveLayers, double contrastThreshold, double edgeThreshold, double sigma, int descriptorType)
        {


            return SIFT.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_SIFT_create_16(nfeatures, nOctaveLayers, contrastThreshold, edgeThreshold, sigma, descriptorType)));


        }


        //
        // C++:  String cv::SIFT::getDefaultName()
        //

        public override string getDefaultName()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(features2d_SIFT_getDefaultName_10(nativeObj)));

            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_SIFT cv::SIFT::create(int nfeatures = 0, int nOctaveLayers = 3, double contrastThreshold = 0.04, double edgeThreshold = 10, double sigma = 1.6)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_SIFT_create_10(int nfeatures, int nOctaveLayers, double contrastThreshold, double edgeThreshold, double sigma);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_SIFT_create_11(int nfeatures, int nOctaveLayers, double contrastThreshold, double edgeThreshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_SIFT_create_12(int nfeatures, int nOctaveLayers, double contrastThreshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_SIFT_create_13(int nfeatures, int nOctaveLayers);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_SIFT_create_14(int nfeatures);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_SIFT_create_15();

        // C++: static Ptr_SIFT cv::SIFT::create(int nfeatures, int nOctaveLayers, double contrastThreshold, double edgeThreshold, double sigma, int descriptorType)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_SIFT_create_16(int nfeatures, int nOctaveLayers, double contrastThreshold, double edgeThreshold, double sigma, int descriptorType);

        // C++:  String cv::SIFT::getDefaultName()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_SIFT_getDefaultName_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_SIFT_delete(IntPtr nativeObj);

    }
}
