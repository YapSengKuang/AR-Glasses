
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Xfeatures2dModule
{

    // C++: class BriefDescriptorExtractor
    /**
     * Class for computing BRIEF descriptors described in CITE: calon2010 .
     *
     * bytes legth of the descriptor in bytes, valid values are: 16, 32 (default) or 64 .
     * use_orientation sample patterns using keypoints orientation, disabled by default.
     */

    public class BriefDescriptorExtractor : Feature2D
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
                        xfeatures2d_BriefDescriptorExtractor_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal BriefDescriptorExtractor(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new BriefDescriptorExtractor __fromPtr__(IntPtr addr) { return new BriefDescriptorExtractor(addr); }

        //
        // C++: static Ptr_BriefDescriptorExtractor cv::xfeatures2d::BriefDescriptorExtractor::create(int bytes = 32, bool use_orientation = false)
        //

        public static BriefDescriptorExtractor create(int bytes, bool use_orientation)
        {


            return BriefDescriptorExtractor.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_BriefDescriptorExtractor_create_10(bytes, use_orientation)));


        }

        public static BriefDescriptorExtractor create(int bytes)
        {


            return BriefDescriptorExtractor.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_BriefDescriptorExtractor_create_11(bytes)));


        }

        public static BriefDescriptorExtractor create()
        {


            return BriefDescriptorExtractor.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_BriefDescriptorExtractor_create_12()));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_BriefDescriptorExtractor cv::xfeatures2d::BriefDescriptorExtractor::create(int bytes = 32, bool use_orientation = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_BriefDescriptorExtractor_create_10(int bytes, [MarshalAs(UnmanagedType.U1)] bool use_orientation);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_BriefDescriptorExtractor_create_11(int bytes);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_BriefDescriptorExtractor_create_12();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_BriefDescriptorExtractor_delete(IntPtr nativeObj);

    }
}
