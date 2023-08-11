
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Xfeatures2dModule
{

    // C++: class MSDDetector
    /**
     * Class implementing the MSD (*Maximal Self-Dissimilarity*) keypoint detector, described in CITE: Tombari14.
     *
     * The algorithm implements a novel interest point detector stemming from the intuition that image patches
     * which are highly dissimilar over a relatively large extent of their surroundings hold the property of
     * being repeatable and distinctive. This concept of "contextual self-dissimilarity" reverses the key
     * paradigm of recent successful techniques such as the Local Self-Similarity descriptor and the Non-Local
     * Means filter, which build upon the presence of similar - rather than dissimilar - patches. Moreover,
     * it extends to contextual information the local self-dissimilarity notion embedded in established
     * detectors of corner-like interest points, thereby achieving enhanced repeatability, distinctiveness and
     * localization accuracy.
     */

    public class MSDDetector : Feature2D
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
                        xfeatures2d_MSDDetector_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal MSDDetector(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new MSDDetector __fromPtr__(IntPtr addr) { return new MSDDetector(addr); }

#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_MSDDetector_delete(IntPtr nativeObj);

    }
}
