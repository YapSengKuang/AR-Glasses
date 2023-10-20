

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ArucoModule
{
    // C++: class Board
    /**
     * Board of markers
     *
     * A board is a set of markers in the 3D space with a common coordinate system.
     * The common form of a board of marker is a planar (2D) board, however any 3D layout can be used.
     * A Board object is composed by:
     * - The object points of the marker corners, i.e. their coordinates respect to the board system.
     * - The dictionary which indicates the type of markers of the board
     * - The identifier of all the markers in the board.
     */

    public class Board : DisposableOpenCVObject
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
                        aruco_Board_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal Board(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static Board __fromPtr__(IntPtr addr) { return new Board(addr); }

        //
        // C++: static Ptr_Board cv::aruco::Board::create(vector_Mat objPoints, Ptr_Dictionary dictionary, Mat ids)
        //

        /**
         * Provide way to create Board by passing necessary data. Specially needed in Python.
         *
         * param objPoints array of object points of all the marker corners in the board
         * param dictionary the dictionary of markers employed for this board
         * param ids vector of the identifiers of the markers in the board
         *
         * return automatically generated
         */
        public static Board create(List<Mat> objPoints, Dictionary dictionary, Mat ids)
        {
            if (dictionary != null) dictionary.ThrowIfDisposed();
            if (ids != null) ids.ThrowIfDisposed();
            Mat objPoints_mat = Converters.vector_Mat_to_Mat(objPoints);
            return Board.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(aruco_Board_create_10(objPoints_mat.nativeObj, dictionary.getNativeObjAddr(), ids.nativeObj)));


        }


        //
        // C++:  void cv::aruco::Board::setIds(Mat ids)
        //

        /**
         * Set ids vector
         *
         * param ids vector of the identifiers of the markers in the board (should be the same size
         * as objPoints)
         *
         * Recommended way to set ids vector, which will fail if the size of ids does not match size
         * of objPoints.
         */
        public void setIds(Mat ids)
        {
            ThrowIfDisposed();
            if (ids != null) ids.ThrowIfDisposed();

            aruco_Board_setIds_10(nativeObj, ids.nativeObj);


        }


        //
        // C++: vector_vector_Point3f Board::objPoints
        //

        public List<MatOfPoint3f> get_objPoints()
        {
            ThrowIfDisposed();
            List<MatOfPoint3f> retVal = new List<MatOfPoint3f>();
            Mat retValMat = new Mat(DisposableObject.ThrowIfNullIntPtr(aruco_Board_get_1objPoints_10(nativeObj)));
            Converters.Mat_to_vector_vector_Point3f(retValMat, retVal);
            return retVal;
        }


        //
        // C++: Ptr_Dictionary Board::dictionary
        //

        public Dictionary get_dictionary()
        {
            ThrowIfDisposed();

            return Dictionary.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(aruco_Board_get_1dictionary_10(nativeObj)));


        }


        //
        // C++: vector_int Board::ids
        //

        public MatOfInt get_ids()
        {
            ThrowIfDisposed();

            return MatOfInt.fromNativeAddr(DisposableObject.ThrowIfNullIntPtr(aruco_Board_get_1ids_10(nativeObj)));


        }


        //
        // C++: void Board::ids
        //

        public void set_ids(MatOfInt ids)
        {
            ThrowIfDisposed();
            if (ids != null) ids.ThrowIfDisposed();
            Mat ids_mat = ids;
            aruco_Board_set_1ids_10(nativeObj, ids_mat.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_Board cv::aruco::Board::create(vector_Mat objPoints, Ptr_Dictionary dictionary, Mat ids)
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_Board_create_10(IntPtr objPoints_mat_nativeObj, IntPtr dictionary_nativeObj, IntPtr ids_nativeObj);

        // C++:  void cv::aruco::Board::setIds(Mat ids)
        [DllImport(LIBNAME)]
        private static extern void aruco_Board_setIds_10(IntPtr nativeObj, IntPtr ids_nativeObj);

        // C++: vector_vector_Point3f Board::objPoints
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_Board_get_1objPoints_10(IntPtr nativeObj);

        // C++: Ptr_Dictionary Board::dictionary
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_Board_get_1dictionary_10(IntPtr nativeObj);

        // C++: vector_int Board::ids
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_Board_get_1ids_10(IntPtr nativeObj);

        // C++: void Board::ids
        [DllImport(LIBNAME)]
        private static extern void aruco_Board_set_1ids_10(IntPtr nativeObj, IntPtr ids_mat_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void aruco_Board_delete(IntPtr nativeObj);

    }
}
