
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Xfeatures2dModule
{

    // C++: class FREAK
    /**
     * Class implementing the FREAK (*Fast Retina Keypoint*) keypoint descriptor, described in CITE: AOV12 .
     *
     * The algorithm propose a novel keypoint descriptor inspired by the human visual system and more
     * precisely the retina, coined Fast Retina Key- point (FREAK). A cascade of binary strings is
     * computed by efficiently comparing image intensities over a retinal sampling pattern. FREAKs are in
     * general faster to compute with lower memory load and also more robust than SIFT, SURF or BRISK.
     * They are competitive alternatives to existing keypoints in particular for embedded applications.
     *
     * <b>Note:</b>
     * <ul>
     *   <li>
     *       An example on how to use the FREAK descriptor can be found at
     *         opencv_source_code/samples/cpp/freak_demo.cpp
     *   </li>
     * </ul>
     */

    public class FREAK : Feature2D
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
                        xfeatures2d_FREAK_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal FREAK(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new FREAK __fromPtr__(IntPtr addr) { return new FREAK(addr); }

        //
        // C++: static Ptr_FREAK cv::xfeatures2d::FREAK::create(bool orientationNormalized = true, bool scaleNormalized = true, float patternScale = 22.0f, int nOctaves = 4, vector_int selectedPairs = std::vector<int>())
        //

        /**
         * param orientationNormalized Enable orientation normalization.
         *     param scaleNormalized Enable scale normalization.
         *     param patternScale Scaling of the description pattern.
         *     param nOctaves Number of octaves covered by the detected keypoints.
         *     param selectedPairs (Optional) user defined selected pairs indexes,
         * return automatically generated
         */
        public static FREAK create(bool orientationNormalized, bool scaleNormalized, float patternScale, int nOctaves, MatOfInt selectedPairs)
        {
            if (selectedPairs != null) selectedPairs.ThrowIfDisposed();
            Mat selectedPairs_mat = selectedPairs;
            return FREAK.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_FREAK_create_10(orientationNormalized, scaleNormalized, patternScale, nOctaves, selectedPairs_mat.nativeObj)));


        }

        /**
         * param orientationNormalized Enable orientation normalization.
         *     param scaleNormalized Enable scale normalization.
         *     param patternScale Scaling of the description pattern.
         *     param nOctaves Number of octaves covered by the detected keypoints.
         * return automatically generated
         */
        public static FREAK create(bool orientationNormalized, bool scaleNormalized, float patternScale, int nOctaves)
        {


            return FREAK.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_FREAK_create_11(orientationNormalized, scaleNormalized, patternScale, nOctaves)));


        }

        /**
         * param orientationNormalized Enable orientation normalization.
         *     param scaleNormalized Enable scale normalization.
         *     param patternScale Scaling of the description pattern.
         * return automatically generated
         */
        public static FREAK create(bool orientationNormalized, bool scaleNormalized, float patternScale)
        {


            return FREAK.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_FREAK_create_12(orientationNormalized, scaleNormalized, patternScale)));


        }

        /**
         * param orientationNormalized Enable orientation normalization.
         *     param scaleNormalized Enable scale normalization.
         * return automatically generated
         */
        public static FREAK create(bool orientationNormalized, bool scaleNormalized)
        {


            return FREAK.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_FREAK_create_13(orientationNormalized, scaleNormalized)));


        }

        /**
         * param orientationNormalized Enable orientation normalization.
         * return automatically generated
         */
        public static FREAK create(bool orientationNormalized)
        {


            return FREAK.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_FREAK_create_14(orientationNormalized)));


        }

        /**
         * return automatically generated
         */
        public static FREAK create()
        {


            return FREAK.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_FREAK_create_15()));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_FREAK cv::xfeatures2d::FREAK::create(bool orientationNormalized = true, bool scaleNormalized = true, float patternScale = 22.0f, int nOctaves = 4, vector_int selectedPairs = std::vector<int>())
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_FREAK_create_10([MarshalAs(UnmanagedType.U1)] bool orientationNormalized, [MarshalAs(UnmanagedType.U1)] bool scaleNormalized, float patternScale, int nOctaves, IntPtr selectedPairs_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_FREAK_create_11([MarshalAs(UnmanagedType.U1)] bool orientationNormalized, [MarshalAs(UnmanagedType.U1)] bool scaleNormalized, float patternScale, int nOctaves);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_FREAK_create_12([MarshalAs(UnmanagedType.U1)] bool orientationNormalized, [MarshalAs(UnmanagedType.U1)] bool scaleNormalized, float patternScale);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_FREAK_create_13([MarshalAs(UnmanagedType.U1)] bool orientationNormalized, [MarshalAs(UnmanagedType.U1)] bool scaleNormalized);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_FREAK_create_14([MarshalAs(UnmanagedType.U1)] bool orientationNormalized);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_FREAK_create_15();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_FREAK_delete(IntPtr nativeObj);

    }
}
