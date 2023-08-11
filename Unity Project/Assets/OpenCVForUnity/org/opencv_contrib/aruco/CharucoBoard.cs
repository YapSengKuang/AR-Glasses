
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ArucoModule
{

    // C++: class CharucoBoard
    /**
     * ChArUco board
     * Specific class for ChArUco boards. A ChArUco board is a planar board where the markers are placed
     * inside the white squares of a chessboard. The benefits of ChArUco boards is that they provide
     * both, ArUco markers versatility and chessboard corner precision, which is important for
     * calibration and pose estimation.
     * This class also allows the easy creation and drawing of ChArUco boards.
     */

    public class CharucoBoard : Board
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
                        aruco_CharucoBoard_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal CharucoBoard(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new CharucoBoard __fromPtr__(IntPtr addr) { return new CharucoBoard(addr); }

        //
        // C++:  void cv::aruco::CharucoBoard::draw(Size outSize, Mat& img, int marginSize = 0, int borderBits = 1)
        //

        /**
         * Draw a ChArUco board
         *
         * param outSize size of the output image in pixels.
         * param img output image with the board. The size of this image will be outSize
         * and the board will be on the center, keeping the board proportions.
         * param marginSize minimum margins (in pixels) of the board in the output image
         * param borderBits width of the marker borders.
         *
         * This function return the image of the ChArUco board, ready to be printed.
         */
        public void draw(Size outSize, Mat img, int marginSize, int borderBits)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();

            aruco_CharucoBoard_draw_10(nativeObj, outSize.width, outSize.height, img.nativeObj, marginSize, borderBits);


        }

        /**
         * Draw a ChArUco board
         *
         * param outSize size of the output image in pixels.
         * param img output image with the board. The size of this image will be outSize
         * and the board will be on the center, keeping the board proportions.
         * param marginSize minimum margins (in pixels) of the board in the output image
         *
         * This function return the image of the ChArUco board, ready to be printed.
         */
        public void draw(Size outSize, Mat img, int marginSize)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();

            aruco_CharucoBoard_draw_11(nativeObj, outSize.width, outSize.height, img.nativeObj, marginSize);


        }

        /**
         * Draw a ChArUco board
         *
         * param outSize size of the output image in pixels.
         * param img output image with the board. The size of this image will be outSize
         * and the board will be on the center, keeping the board proportions.
         *
         * This function return the image of the ChArUco board, ready to be printed.
         */
        public void draw(Size outSize, Mat img)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();

            aruco_CharucoBoard_draw_12(nativeObj, outSize.width, outSize.height, img.nativeObj);


        }


        //
        // C++: static Ptr_CharucoBoard cv::aruco::CharucoBoard::create(int squaresX, int squaresY, float squareLength, float markerLength, Ptr_Dictionary dictionary)
        //

        /**
         * Create a CharucoBoard object
         *
         * param squaresX number of chessboard squares in X direction
         * param squaresY number of chessboard squares in Y direction
         * param squareLength chessboard square side length (normally in meters)
         * param markerLength marker side length (same unit than squareLength)
         * param dictionary dictionary of markers indicating the type of markers.
         * The first markers in the dictionary are used to fill the white chessboard squares.
         * return the output CharucoBoard object
         *
         * This functions creates a CharucoBoard object given the number of squares in each direction
         * and the size of the markers and chessboard squares.
         */
        public static CharucoBoard create(int squaresX, int squaresY, float squareLength, float markerLength, Dictionary dictionary)
        {
            if (dictionary != null) dictionary.ThrowIfDisposed();

            return CharucoBoard.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(aruco_CharucoBoard_create_10(squaresX, squaresY, squareLength, markerLength, dictionary.getNativeObjAddr())));


        }


        //
        // C++:  Size cv::aruco::CharucoBoard::getChessboardSize()
        //

        public Size getChessboardSize()
        {
            ThrowIfDisposed();

            double[] tmpArray = new double[2];
            aruco_CharucoBoard_getChessboardSize_10(nativeObj, tmpArray);
            Size retVal = new Size(tmpArray);

            return retVal;
        }


        //
        // C++:  float cv::aruco::CharucoBoard::getSquareLength()
        //

        public float getSquareLength()
        {
            ThrowIfDisposed();

            return aruco_CharucoBoard_getSquareLength_10(nativeObj);


        }


        //
        // C++:  float cv::aruco::CharucoBoard::getMarkerLength()
        //

        public float getMarkerLength()
        {
            ThrowIfDisposed();

            return aruco_CharucoBoard_getMarkerLength_10(nativeObj);


        }


        //
        // C++: vector_Point3f CharucoBoard::chessboardCorners
        //

        public MatOfPoint3f get_chessboardCorners()
        {
            ThrowIfDisposed();

            return MatOfPoint3f.fromNativeAddr(DisposableObject.ThrowIfNullIntPtr(aruco_CharucoBoard_get_1chessboardCorners_10(nativeObj)));


        }


        //
        // C++: vector_vector_int CharucoBoard::nearestMarkerIdx
        //

        // Return type 'vector_vector_int' is not supported, skipping the function


        //
        // C++: vector_vector_int CharucoBoard::nearestMarkerCorners
        //

        // Return type 'vector_vector_int' is not supported, skipping the function


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::aruco::CharucoBoard::draw(Size outSize, Mat& img, int marginSize = 0, int borderBits = 1)
        [DllImport(LIBNAME)]
        private static extern void aruco_CharucoBoard_draw_10(IntPtr nativeObj, double outSize_width, double outSize_height, IntPtr img_nativeObj, int marginSize, int borderBits);
        [DllImport(LIBNAME)]
        private static extern void aruco_CharucoBoard_draw_11(IntPtr nativeObj, double outSize_width, double outSize_height, IntPtr img_nativeObj, int marginSize);
        [DllImport(LIBNAME)]
        private static extern void aruco_CharucoBoard_draw_12(IntPtr nativeObj, double outSize_width, double outSize_height, IntPtr img_nativeObj);

        // C++: static Ptr_CharucoBoard cv::aruco::CharucoBoard::create(int squaresX, int squaresY, float squareLength, float markerLength, Ptr_Dictionary dictionary)
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_CharucoBoard_create_10(int squaresX, int squaresY, float squareLength, float markerLength, IntPtr dictionary_nativeObj);

        // C++:  Size cv::aruco::CharucoBoard::getChessboardSize()
        [DllImport(LIBNAME)]
        private static extern void aruco_CharucoBoard_getChessboardSize_10(IntPtr nativeObj, double[] retVal);

        // C++:  float cv::aruco::CharucoBoard::getSquareLength()
        [DllImport(LIBNAME)]
        private static extern float aruco_CharucoBoard_getSquareLength_10(IntPtr nativeObj);

        // C++:  float cv::aruco::CharucoBoard::getMarkerLength()
        [DllImport(LIBNAME)]
        private static extern float aruco_CharucoBoard_getMarkerLength_10(IntPtr nativeObj);

        // C++: vector_Point3f CharucoBoard::chessboardCorners
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_CharucoBoard_get_1chessboardCorners_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void aruco_CharucoBoard_delete(IntPtr nativeObj);

    }
}
