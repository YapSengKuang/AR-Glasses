
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Xfeatures2dModule
{

    // C++: class HarrisLaplaceFeatureDetector
    /**
     * Class implementing the Harris-Laplace feature detector as described in CITE: Mikolajczyk2004.
     */

    public class HarrisLaplaceFeatureDetector : Feature2D
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
                        xfeatures2d_HarrisLaplaceFeatureDetector_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal HarrisLaplaceFeatureDetector(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new HarrisLaplaceFeatureDetector __fromPtr__(IntPtr addr) { return new HarrisLaplaceFeatureDetector(addr); }

        //
        // C++: static Ptr_HarrisLaplaceFeatureDetector cv::xfeatures2d::HarrisLaplaceFeatureDetector::create(int numOctaves = 6, float corn_thresh = 0.01f, float DOG_thresh = 0.01f, int maxCorners = 5000, int num_layers = 4)
        //

        /**
         * Creates a new implementation instance.
         *
         * param numOctaves the number of octaves in the scale-space pyramid
         * param corn_thresh the threshold for the Harris cornerness measure
         * param DOG_thresh the threshold for the Difference-of-Gaussians scale selection
         * param maxCorners the maximum number of corners to consider
         * param num_layers the number of intermediate scales per octave
         * return automatically generated
         */
        public static HarrisLaplaceFeatureDetector create(int numOctaves, float corn_thresh, float DOG_thresh, int maxCorners, int num_layers)
        {


            return HarrisLaplaceFeatureDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_HarrisLaplaceFeatureDetector_create_10(numOctaves, corn_thresh, DOG_thresh, maxCorners, num_layers)));


        }

        /**
         * Creates a new implementation instance.
         *
         * param numOctaves the number of octaves in the scale-space pyramid
         * param corn_thresh the threshold for the Harris cornerness measure
         * param DOG_thresh the threshold for the Difference-of-Gaussians scale selection
         * param maxCorners the maximum number of corners to consider
         * return automatically generated
         */
        public static HarrisLaplaceFeatureDetector create(int numOctaves, float corn_thresh, float DOG_thresh, int maxCorners)
        {


            return HarrisLaplaceFeatureDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_HarrisLaplaceFeatureDetector_create_11(numOctaves, corn_thresh, DOG_thresh, maxCorners)));


        }

        /**
         * Creates a new implementation instance.
         *
         * param numOctaves the number of octaves in the scale-space pyramid
         * param corn_thresh the threshold for the Harris cornerness measure
         * param DOG_thresh the threshold for the Difference-of-Gaussians scale selection
         * return automatically generated
         */
        public static HarrisLaplaceFeatureDetector create(int numOctaves, float corn_thresh, float DOG_thresh)
        {


            return HarrisLaplaceFeatureDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_HarrisLaplaceFeatureDetector_create_12(numOctaves, corn_thresh, DOG_thresh)));


        }

        /**
         * Creates a new implementation instance.
         *
         * param numOctaves the number of octaves in the scale-space pyramid
         * param corn_thresh the threshold for the Harris cornerness measure
         * return automatically generated
         */
        public static HarrisLaplaceFeatureDetector create(int numOctaves, float corn_thresh)
        {


            return HarrisLaplaceFeatureDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_HarrisLaplaceFeatureDetector_create_13(numOctaves, corn_thresh)));


        }

        /**
         * Creates a new implementation instance.
         *
         * param numOctaves the number of octaves in the scale-space pyramid
         * return automatically generated
         */
        public static HarrisLaplaceFeatureDetector create(int numOctaves)
        {


            return HarrisLaplaceFeatureDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_HarrisLaplaceFeatureDetector_create_14(numOctaves)));


        }

        /**
         * Creates a new implementation instance.
         *
         * return automatically generated
         */
        public static HarrisLaplaceFeatureDetector create()
        {


            return HarrisLaplaceFeatureDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_HarrisLaplaceFeatureDetector_create_15()));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_HarrisLaplaceFeatureDetector cv::xfeatures2d::HarrisLaplaceFeatureDetector::create(int numOctaves = 6, float corn_thresh = 0.01f, float DOG_thresh = 0.01f, int maxCorners = 5000, int num_layers = 4)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_HarrisLaplaceFeatureDetector_create_10(int numOctaves, float corn_thresh, float DOG_thresh, int maxCorners, int num_layers);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_HarrisLaplaceFeatureDetector_create_11(int numOctaves, float corn_thresh, float DOG_thresh, int maxCorners);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_HarrisLaplaceFeatureDetector_create_12(int numOctaves, float corn_thresh, float DOG_thresh);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_HarrisLaplaceFeatureDetector_create_13(int numOctaves, float corn_thresh);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_HarrisLaplaceFeatureDetector_create_14(int numOctaves);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_HarrisLaplaceFeatureDetector_create_15();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_HarrisLaplaceFeatureDetector_delete(IntPtr nativeObj);

    }
}
