
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ArucoModule
{

    // C++: class GridBoard
    /**
     * Planar board with grid arrangement of markers
     * More common type of board. All markers are placed in the same plane in a grid arrangement.
     * The board can be drawn using drawPlanarBoard() function (SEE: drawPlanarBoard)
     */

    public class GridBoard : Board
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
                        aruco_GridBoard_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal GridBoard(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new GridBoard __fromPtr__(IntPtr addr) { return new GridBoard(addr); }

        //
        // C++:  void cv::aruco::GridBoard::draw(Size outSize, Mat& img, int marginSize = 0, int borderBits = 1)
        //

        /**
         * Draw a GridBoard
         *
         * param outSize size of the output image in pixels.
         * param img output image with the board. The size of this image will be outSize
         * and the board will be on the center, keeping the board proportions.
         * param marginSize minimum margins (in pixels) of the board in the output image
         * param borderBits width of the marker borders.
         *
         * This function return the image of the GridBoard, ready to be printed.
         */
        public void draw(Size outSize, Mat img, int marginSize, int borderBits)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();

            aruco_GridBoard_draw_10(nativeObj, outSize.width, outSize.height, img.nativeObj, marginSize, borderBits);


        }

        /**
         * Draw a GridBoard
         *
         * param outSize size of the output image in pixels.
         * param img output image with the board. The size of this image will be outSize
         * and the board will be on the center, keeping the board proportions.
         * param marginSize minimum margins (in pixels) of the board in the output image
         *
         * This function return the image of the GridBoard, ready to be printed.
         */
        public void draw(Size outSize, Mat img, int marginSize)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();

            aruco_GridBoard_draw_11(nativeObj, outSize.width, outSize.height, img.nativeObj, marginSize);


        }

        /**
         * Draw a GridBoard
         *
         * param outSize size of the output image in pixels.
         * param img output image with the board. The size of this image will be outSize
         * and the board will be on the center, keeping the board proportions.
         *
         * This function return the image of the GridBoard, ready to be printed.
         */
        public void draw(Size outSize, Mat img)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();

            aruco_GridBoard_draw_12(nativeObj, outSize.width, outSize.height, img.nativeObj);


        }


        //
        // C++: static Ptr_GridBoard cv::aruco::GridBoard::create(int markersX, int markersY, float markerLength, float markerSeparation, Ptr_Dictionary dictionary, int firstMarker = 0)
        //

        /**
         * Create a GridBoard object
         *
         * param markersX number of markers in X direction
         * param markersY number of markers in Y direction
         * param markerLength marker side length (normally in meters)
         * param markerSeparation separation between two markers (same unit as markerLength)
         * param dictionary dictionary of markers indicating the type of markers
         * param firstMarker id of first marker in dictionary to use on board.
         * return the output GridBoard object
         *
         * This functions creates a GridBoard object given the number of markers in each direction and
         * the marker size and marker separation.
         */
        public static GridBoard create(int markersX, int markersY, float markerLength, float markerSeparation, Dictionary dictionary, int firstMarker)
        {
            if (dictionary != null) dictionary.ThrowIfDisposed();

            return GridBoard.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(aruco_GridBoard_create_10(markersX, markersY, markerLength, markerSeparation, dictionary.getNativeObjAddr(), firstMarker)));


        }

        /**
         * Create a GridBoard object
         *
         * param markersX number of markers in X direction
         * param markersY number of markers in Y direction
         * param markerLength marker side length (normally in meters)
         * param markerSeparation separation between two markers (same unit as markerLength)
         * param dictionary dictionary of markers indicating the type of markers
         * return the output GridBoard object
         *
         * This functions creates a GridBoard object given the number of markers in each direction and
         * the marker size and marker separation.
         */
        public static GridBoard create(int markersX, int markersY, float markerLength, float markerSeparation, Dictionary dictionary)
        {
            if (dictionary != null) dictionary.ThrowIfDisposed();

            return GridBoard.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(aruco_GridBoard_create_11(markersX, markersY, markerLength, markerSeparation, dictionary.getNativeObjAddr())));


        }


        //
        // C++:  Size cv::aruco::GridBoard::getGridSize()
        //

        public Size getGridSize()
        {
            ThrowIfDisposed();

            double[] tmpArray = new double[2];
            aruco_GridBoard_getGridSize_10(nativeObj, tmpArray);
            Size retVal = new Size(tmpArray);

            return retVal;
        }


        //
        // C++:  float cv::aruco::GridBoard::getMarkerLength()
        //

        public float getMarkerLength()
        {
            ThrowIfDisposed();

            return aruco_GridBoard_getMarkerLength_10(nativeObj);


        }


        //
        // C++:  float cv::aruco::GridBoard::getMarkerSeparation()
        //

        public float getMarkerSeparation()
        {
            ThrowIfDisposed();

            return aruco_GridBoard_getMarkerSeparation_10(nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::aruco::GridBoard::draw(Size outSize, Mat& img, int marginSize = 0, int borderBits = 1)
        [DllImport(LIBNAME)]
        private static extern void aruco_GridBoard_draw_10(IntPtr nativeObj, double outSize_width, double outSize_height, IntPtr img_nativeObj, int marginSize, int borderBits);
        [DllImport(LIBNAME)]
        private static extern void aruco_GridBoard_draw_11(IntPtr nativeObj, double outSize_width, double outSize_height, IntPtr img_nativeObj, int marginSize);
        [DllImport(LIBNAME)]
        private static extern void aruco_GridBoard_draw_12(IntPtr nativeObj, double outSize_width, double outSize_height, IntPtr img_nativeObj);

        // C++: static Ptr_GridBoard cv::aruco::GridBoard::create(int markersX, int markersY, float markerLength, float markerSeparation, Ptr_Dictionary dictionary, int firstMarker = 0)
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_GridBoard_create_10(int markersX, int markersY, float markerLength, float markerSeparation, IntPtr dictionary_nativeObj, int firstMarker);
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_GridBoard_create_11(int markersX, int markersY, float markerLength, float markerSeparation, IntPtr dictionary_nativeObj);

        // C++:  Size cv::aruco::GridBoard::getGridSize()
        [DllImport(LIBNAME)]
        private static extern void aruco_GridBoard_getGridSize_10(IntPtr nativeObj, double[] retVal);

        // C++:  float cv::aruco::GridBoard::getMarkerLength()
        [DllImport(LIBNAME)]
        private static extern float aruco_GridBoard_getMarkerLength_10(IntPtr nativeObj);

        // C++:  float cv::aruco::GridBoard::getMarkerSeparation()
        [DllImport(LIBNAME)]
        private static extern float aruco_GridBoard_getMarkerSeparation_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void aruco_GridBoard_delete(IntPtr nativeObj);

    }
}
