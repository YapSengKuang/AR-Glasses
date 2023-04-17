
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Xfeatures2dModule
{

    // C++: class DAISY
    /**
     * Class implementing DAISY descriptor, described in CITE: Tola10
     *
     * radius radius of the descriptor at the initial scale
     * q_radius amount of radial range division quantity
     * q_theta amount of angular range division quantity
     * q_hist amount of gradient orientations range division quantity
     * norm choose descriptors normalization type, where
     * DAISY::NRM_NONE will not do any normalization (default),
     * DAISY::NRM_PARTIAL mean that histograms are normalized independently for L2 norm equal to 1.0,
     * DAISY::NRM_FULL mean that descriptors are normalized for L2 norm equal to 1.0,
     * DAISY::NRM_SIFT mean that descriptors are normalized for L2 norm equal to 1.0 but no individual one is bigger than 0.154 as in SIFT
     * H optional 3x3 homography matrix used to warp the grid of daisy but sampling keypoints remains unwarped on image
     * interpolation switch to disable interpolation for speed improvement at minor quality loss
     * use_orientation sample patterns using keypoints orientation, disabled by default.
     */

    public class DAISY : Feature2D
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
                        xfeatures2d_DAISY_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal DAISY(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new DAISY __fromPtr__(IntPtr addr) { return new DAISY(addr); }

        // C++: enum cv.xfeatures2d.DAISY.NormalizationType
        public const int NRM_NONE = 100;
        public const int NRM_PARTIAL = 101;
        public const int NRM_FULL = 102;
        public const int NRM_SIFT = 103;
        //
        // C++: static Ptr_DAISY cv::xfeatures2d::DAISY::create(float radius = 15, int q_radius = 3, int q_theta = 8, int q_hist = 8, DAISY_NormalizationType norm = DAISY::NRM_NONE, Mat H = Mat(), bool interpolation = true, bool use_orientation = false)
        //

        public static DAISY create(float radius, int q_radius, int q_theta, int q_hist, Mat H, bool interpolation, bool use_orientation)
        {
            if (H != null) H.ThrowIfDisposed();

            return DAISY.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_DAISY_create_10(radius, q_radius, q_theta, q_hist, H.nativeObj, interpolation, use_orientation)));


        }

        public static DAISY create(float radius, int q_radius, int q_theta, int q_hist, Mat H, bool interpolation)
        {
            if (H != null) H.ThrowIfDisposed();

            return DAISY.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_DAISY_create_11(radius, q_radius, q_theta, q_hist, H.nativeObj, interpolation)));


        }

        public static DAISY create(float radius, int q_radius, int q_theta, int q_hist, Mat H)
        {
            if (H != null) H.ThrowIfDisposed();

            return DAISY.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_DAISY_create_12(radius, q_radius, q_theta, q_hist, H.nativeObj)));


        }

        public static DAISY create(float radius, int q_radius, int q_theta, int q_hist)
        {


            return DAISY.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_DAISY_create_13(radius, q_radius, q_theta, q_hist)));


        }

        public static DAISY create(float radius, int q_radius, int q_theta)
        {


            return DAISY.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_DAISY_create_15(radius, q_radius, q_theta)));


        }

        public static DAISY create(float radius, int q_radius)
        {


            return DAISY.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_DAISY_create_16(radius, q_radius)));


        }

        public static DAISY create(float radius)
        {


            return DAISY.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_DAISY_create_17(radius)));


        }

        public static DAISY create()
        {


            return DAISY.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_DAISY_create_18()));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_DAISY cv::xfeatures2d::DAISY::create(float radius = 15, int q_radius = 3, int q_theta = 8, int q_hist = 8, DAISY_NormalizationType norm = DAISY::NRM_NONE, Mat H = Mat(), bool interpolation = true, bool use_orientation = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_DAISY_create_10(float radius, int q_radius, int q_theta, int q_hist, IntPtr H_nativeObj, [MarshalAs(UnmanagedType.U1)] bool interpolation, [MarshalAs(UnmanagedType.U1)] bool use_orientation);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_DAISY_create_11(float radius, int q_radius, int q_theta, int q_hist, IntPtr H_nativeObj, [MarshalAs(UnmanagedType.U1)] bool interpolation);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_DAISY_create_12(float radius, int q_radius, int q_theta, int q_hist, IntPtr H_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_DAISY_create_13(float radius, int q_radius, int q_theta, int q_hist);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_DAISY_create_15(float radius, int q_radius, int q_theta);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_DAISY_create_16(float radius, int q_radius);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_DAISY_create_17(float radius);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_DAISY_create_18();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_DAISY_delete(IntPtr nativeObj);

    }
}
