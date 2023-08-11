

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ArucoModule
{
    // C++: class Dictionary
    /**
     * Dictionary/Set of markers. It contains the inner codification
     *
     * bytesList contains the marker codewords where
     * - bytesList.rows is the dictionary size
     * - each marker is encoded using {code nbytes = ceil(markerSize*markerSize/8.)}
     * - each row contains all 4 rotations of the marker, so its length is {code 4*nbytes}
     *
     * {code bytesList.ptr(i)[k*nbytes + j]} is then the j-th byte of i-th marker, in its k-th rotation.
     */

    public class Dictionary : DisposableOpenCVObject
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
                        aruco_Dictionary_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal Dictionary(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static Dictionary __fromPtr__(IntPtr addr) { return new Dictionary(addr); }

        //
        // C++: static Ptr_Dictionary cv::aruco::Dictionary::create(int nMarkers, int markerSize, int randomSeed = 0)
        //

        /**
         * SEE: generateCustomDictionary
         * param nMarkers automatically generated
         * param markerSize automatically generated
         * param randomSeed automatically generated
         * return automatically generated
         */
        public static Dictionary create(int nMarkers, int markerSize, int randomSeed)
        {


            return Dictionary.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(aruco_Dictionary_create_10(nMarkers, markerSize, randomSeed)));


        }

        /**
         * SEE: generateCustomDictionary
         * param nMarkers automatically generated
         * param markerSize automatically generated
         * return automatically generated
         */
        public static Dictionary create(int nMarkers, int markerSize)
        {


            return Dictionary.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(aruco_Dictionary_create_11(nMarkers, markerSize)));


        }


        //
        // C++: static Ptr_Dictionary cv::aruco::Dictionary::create(int nMarkers, int markerSize, Ptr_Dictionary baseDictionary, int randomSeed = 0)
        //

        /**
         * SEE: generateCustomDictionary
         * param nMarkers automatically generated
         * param markerSize automatically generated
         * param baseDictionary automatically generated
         * param randomSeed automatically generated
         * return automatically generated
         */
        public static Dictionary create_from(int nMarkers, int markerSize, Dictionary baseDictionary, int randomSeed)
        {
            if (baseDictionary != null) baseDictionary.ThrowIfDisposed();

            return Dictionary.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(aruco_Dictionary_create_1from_10(nMarkers, markerSize, baseDictionary.getNativeObjAddr(), randomSeed)));


        }

        /**
         * SEE: generateCustomDictionary
         * param nMarkers automatically generated
         * param markerSize automatically generated
         * param baseDictionary automatically generated
         * return automatically generated
         */
        public static Dictionary create_from(int nMarkers, int markerSize, Dictionary baseDictionary)
        {
            if (baseDictionary != null) baseDictionary.ThrowIfDisposed();

            return Dictionary.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(aruco_Dictionary_create_1from_11(nMarkers, markerSize, baseDictionary.getNativeObjAddr())));


        }


        //
        // C++: static bool cv::aruco::Dictionary::readDictionary(FileNode fn, Ptr_aruco_Dictionary dictionary)
        //

        // Unknown type 'FileNode' (I), skipping the function


        //
        // C++: static Ptr_Dictionary cv::aruco::Dictionary::get(int dict)
        //

        /**
         * SEE: getPredefinedDictionary
         * param dict automatically generated
         * return automatically generated
         */
        public static Dictionary get(int dict)
        {


            return Dictionary.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(aruco_Dictionary_get_10(dict)));


        }


        //
        // C++:  void cv::aruco::Dictionary::drawMarker(int id, int sidePixels, Mat& _img, int borderBits = 1)
        //

        /**
         * Draw a canonical marker image
         * param id automatically generated
         * param sidePixels automatically generated
         * param _img automatically generated
         * param borderBits automatically generated
         */
        public void drawMarker(int id, int sidePixels, Mat _img, int borderBits)
        {
            ThrowIfDisposed();
            if (_img != null) _img.ThrowIfDisposed();

            aruco_Dictionary_drawMarker_10(nativeObj, id, sidePixels, _img.nativeObj, borderBits);


        }

        /**
         * Draw a canonical marker image
         * param id automatically generated
         * param sidePixels automatically generated
         * param _img automatically generated
         */
        public void drawMarker(int id, int sidePixels, Mat _img)
        {
            ThrowIfDisposed();
            if (_img != null) _img.ThrowIfDisposed();

            aruco_Dictionary_drawMarker_11(nativeObj, id, sidePixels, _img.nativeObj);


        }


        //
        // C++: static Mat cv::aruco::Dictionary::getByteListFromBits(Mat bits)
        //

        /**
         * Transform matrix of bits to list of bytes in the 4 rotations
         * param bits automatically generated
         * return automatically generated
         */
        public static Mat getByteListFromBits(Mat bits)
        {
            if (bits != null) bits.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(aruco_Dictionary_getByteListFromBits_10(bits.nativeObj)));


        }


        //
        // C++: static Mat cv::aruco::Dictionary::getBitsFromByteList(Mat byteList, int markerSize)
        //

        /**
         * Transform list of bytes to matrix of bits
         * param byteList automatically generated
         * param markerSize automatically generated
         * return automatically generated
         */
        public static Mat getBitsFromByteList(Mat byteList, int markerSize)
        {
            if (byteList != null) byteList.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(aruco_Dictionary_getBitsFromByteList_10(byteList.nativeObj, markerSize)));


        }


        //
        // C++: Mat Dictionary::bytesList
        //

        public Mat get_bytesList()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(aruco_Dictionary_get_1bytesList_10(nativeObj)));


        }


        //
        // C++: void Dictionary::bytesList
        //

        public void set_bytesList(Mat bytesList)
        {
            ThrowIfDisposed();
            if (bytesList != null) bytesList.ThrowIfDisposed();

            aruco_Dictionary_set_1bytesList_10(nativeObj, bytesList.nativeObj);


        }


        //
        // C++: int Dictionary::markerSize
        //

        public int get_markerSize()
        {
            ThrowIfDisposed();

            return aruco_Dictionary_get_1markerSize_10(nativeObj);


        }


        //
        // C++: void Dictionary::markerSize
        //

        public void set_markerSize(int markerSize)
        {
            ThrowIfDisposed();

            aruco_Dictionary_set_1markerSize_10(nativeObj, markerSize);


        }


        //
        // C++: int Dictionary::maxCorrectionBits
        //

        public int get_maxCorrectionBits()
        {
            ThrowIfDisposed();

            return aruco_Dictionary_get_1maxCorrectionBits_10(nativeObj);


        }


        //
        // C++: void Dictionary::maxCorrectionBits
        //

        public void set_maxCorrectionBits(int maxCorrectionBits)
        {
            ThrowIfDisposed();

            aruco_Dictionary_set_1maxCorrectionBits_10(nativeObj, maxCorrectionBits);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_Dictionary cv::aruco::Dictionary::create(int nMarkers, int markerSize, int randomSeed = 0)
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_Dictionary_create_10(int nMarkers, int markerSize, int randomSeed);
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_Dictionary_create_11(int nMarkers, int markerSize);

        // C++: static Ptr_Dictionary cv::aruco::Dictionary::create(int nMarkers, int markerSize, Ptr_Dictionary baseDictionary, int randomSeed = 0)
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_Dictionary_create_1from_10(int nMarkers, int markerSize, IntPtr baseDictionary_nativeObj, int randomSeed);
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_Dictionary_create_1from_11(int nMarkers, int markerSize, IntPtr baseDictionary_nativeObj);

        // C++: static Ptr_Dictionary cv::aruco::Dictionary::get(int dict)
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_Dictionary_get_10(int dict);

        // C++:  void cv::aruco::Dictionary::drawMarker(int id, int sidePixels, Mat& _img, int borderBits = 1)
        [DllImport(LIBNAME)]
        private static extern void aruco_Dictionary_drawMarker_10(IntPtr nativeObj, int id, int sidePixels, IntPtr _img_nativeObj, int borderBits);
        [DllImport(LIBNAME)]
        private static extern void aruco_Dictionary_drawMarker_11(IntPtr nativeObj, int id, int sidePixels, IntPtr _img_nativeObj);

        // C++: static Mat cv::aruco::Dictionary::getByteListFromBits(Mat bits)
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_Dictionary_getByteListFromBits_10(IntPtr bits_nativeObj);

        // C++: static Mat cv::aruco::Dictionary::getBitsFromByteList(Mat byteList, int markerSize)
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_Dictionary_getBitsFromByteList_10(IntPtr byteList_nativeObj, int markerSize);

        // C++: Mat Dictionary::bytesList
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_Dictionary_get_1bytesList_10(IntPtr nativeObj);

        // C++: void Dictionary::bytesList
        [DllImport(LIBNAME)]
        private static extern void aruco_Dictionary_set_1bytesList_10(IntPtr nativeObj, IntPtr bytesList_nativeObj);

        // C++: int Dictionary::markerSize
        [DllImport(LIBNAME)]
        private static extern int aruco_Dictionary_get_1markerSize_10(IntPtr nativeObj);

        // C++: void Dictionary::markerSize
        [DllImport(LIBNAME)]
        private static extern void aruco_Dictionary_set_1markerSize_10(IntPtr nativeObj, int markerSize);

        // C++: int Dictionary::maxCorrectionBits
        [DllImport(LIBNAME)]
        private static extern int aruco_Dictionary_get_1maxCorrectionBits_10(IntPtr nativeObj);

        // C++: void Dictionary::maxCorrectionBits
        [DllImport(LIBNAME)]
        private static extern void aruco_Dictionary_set_1maxCorrectionBits_10(IntPtr nativeObj, int maxCorrectionBits);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void aruco_Dictionary_delete(IntPtr nativeObj);

    }
}
