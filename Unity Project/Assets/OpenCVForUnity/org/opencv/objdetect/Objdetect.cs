
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ObjdetectModule
{
    // C++: class Objdetect


    public class Objdetect
    {

        // C++: enum <unnamed>
        public const int CASCADE_DO_CANNY_PRUNING = 1;
        public const int CASCADE_SCALE_IMAGE = 2;
        public const int CASCADE_FIND_BIGGEST_OBJECT = 4;
        public const int CASCADE_DO_ROUGH_SEARCH = 8;
        // C++: enum cv.DetectionBasedTracker.ObjectStatus
        public const int DetectionBasedTracker_DETECTED_NOT_SHOWN_YET = 0;
        public const int DetectionBasedTracker_DETECTED = 1;
        public const int DetectionBasedTracker_DETECTED_TEMPORARY_LOST = 2;
        public const int DetectionBasedTracker_WRONG_OBJECT = 3;
        //
        // C++:  void cv::groupRectangles(vector_Rect& rectList, vector_int& weights, int groupThreshold, double eps = 0.2)
        //

        public static void groupRectangles(MatOfRect rectList, MatOfInt weights, int groupThreshold, double eps)
        {
            if (rectList != null) rectList.ThrowIfDisposed();
            if (weights != null) weights.ThrowIfDisposed();
            Mat rectList_mat = rectList;
            Mat weights_mat = weights;
            objdetect_Objdetect_groupRectangles_10(rectList_mat.nativeObj, weights_mat.nativeObj, groupThreshold, eps);


        }

        public static void groupRectangles(MatOfRect rectList, MatOfInt weights, int groupThreshold)
        {
            if (rectList != null) rectList.ThrowIfDisposed();
            if (weights != null) weights.ThrowIfDisposed();
            Mat rectList_mat = rectList;
            Mat weights_mat = weights;
            objdetect_Objdetect_groupRectangles_11(rectList_mat.nativeObj, weights_mat.nativeObj, groupThreshold);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::groupRectangles(vector_Rect& rectList, vector_int& weights, int groupThreshold, double eps = 0.2)
        [DllImport(LIBNAME)]
        private static extern void objdetect_Objdetect_groupRectangles_10(IntPtr rectList_mat_nativeObj, IntPtr weights_mat_nativeObj, int groupThreshold, double eps);
        [DllImport(LIBNAME)]
        private static extern void objdetect_Objdetect_groupRectangles_11(IntPtr rectList_mat_nativeObj, IntPtr weights_mat_nativeObj, int groupThreshold);

    }
}
