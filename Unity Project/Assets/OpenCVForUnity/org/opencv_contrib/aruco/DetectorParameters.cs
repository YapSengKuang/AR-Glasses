

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ArucoModule
{
    // C++: class DetectorParameters
    /**
     * Parameters for the detectMarker process:
     * - adaptiveThreshWinSizeMin: minimum window size for adaptive thresholding before finding
     * contours (default 3).
     * - adaptiveThreshWinSizeMax: maximum window size for adaptive thresholding before finding
     * contours (default 23).
     * - adaptiveThreshWinSizeStep: increments from adaptiveThreshWinSizeMin to adaptiveThreshWinSizeMax
     * during the thresholding (default 10).
     * - adaptiveThreshConstant: constant for adaptive thresholding before finding contours (default 7)
     * - minMarkerPerimeterRate: determine minimum perimeter for marker contour to be detected. This
     * is defined as a rate respect to the maximum dimension of the input image (default 0.03).
     * - maxMarkerPerimeterRate:  determine maximum perimeter for marker contour to be detected. This
     * is defined as a rate respect to the maximum dimension of the input image (default 4.0).
     * - polygonalApproxAccuracyRate: minimum accuracy during the polygonal approximation process to
     * determine which contours are squares. (default 0.03)
     * - minCornerDistanceRate: minimum distance between corners for detected markers relative to its
     * perimeter (default 0.05)
     * - minDistanceToBorder: minimum distance of any corner to the image border for detected markers
     * (in pixels) (default 3)
     * - minMarkerDistanceRate: minimum mean distance beetween two marker corners to be considered
     * similar, so that the smaller one is removed. The rate is relative to the smaller perimeter
     * of the two markers (default 0.05).
     * - cornerRefinementMethod: corner refinement method. (CORNER_REFINE_NONE, no refinement.
     * CORNER_REFINE_SUBPIX, do subpixel refinement. CORNER_REFINE_CONTOUR use contour-Points,
     * CORNER_REFINE_APRILTAG  use the AprilTag2 approach). (default CORNER_REFINE_NONE)
     * - cornerRefinementWinSize: window size for the corner refinement process (in pixels) (default 5).
     * - cornerRefinementMaxIterations: maximum number of iterations for stop criteria of the corner
     * refinement process (default 30).
     * - cornerRefinementMinAccuracy: minimum error for the stop cristeria of the corner refinement
     * process (default: 0.1)
     * - markerBorderBits: number of bits of the marker border, i.e. marker border width (default 1).
     * - perspectiveRemovePixelPerCell: number of bits (per dimension) for each cell of the marker
     * when removing the perspective (default 4).
     * - perspectiveRemoveIgnoredMarginPerCell: width of the margin of pixels on each cell not
     * considered for the determination of the cell bit. Represents the rate respect to the total
     * size of the cell, i.e. perspectiveRemovePixelPerCell (default 0.13)
     * - maxErroneousBitsInBorderRate: maximum number of accepted erroneous bits in the border (i.e.
     * number of allowed white bits in the border). Represented as a rate respect to the total
     * number of bits per marker (default 0.35).
     * - minOtsuStdDev: minimun standard deviation in pixels values during the decodification step to
     * apply Otsu thresholding (otherwise, all the bits are set to 0 or 1 depending on mean higher
     * than 128 or not) (default 5.0)
     * - errorCorrectionRate error correction rate respect to the maximun error correction capability
     * for each dictionary. (default 0.6).
     * - aprilTagMinClusterPixels: reject quads containing too few pixels. (default 5)
     * - aprilTagMaxNmaxima: how many corner candidates to consider when segmenting a group of pixels into a quad. (default 10)
     * - aprilTagCriticalRad: Reject quads where pairs of edges have angles that are close to straight or close to
     * 180 degrees. Zero means that no quads are rejected. (In radians) (default 10*PI/180)
     * - aprilTagMaxLineFitMse:  When fitting lines to the contours, what is the maximum mean squared error
     * allowed?  This is useful in rejecting contours that are far from being quad shaped; rejecting
     * these quads "early" saves expensive decoding processing. (default 10.0)
     * - aprilTagMinWhiteBlackDiff: When we build our model of black &amp; white pixels, we add an extra check that
     * the white model must be (overall) brighter than the black model.  How much brighter? (in pixel values, [0,255]). (default 5)
     * - aprilTagDeglitch:  should the thresholded image be deglitched? Only useful for very noisy images. (default 0)
     * - aprilTagQuadDecimate: Detection of quads can be done on a lower-resolution image, improving speed at a
     * cost of pose accuracy and a slight decrease in detection rate. Decoding the binary payload is still
     * done at full resolution. (default 0.0)
     * - aprilTagQuadSigma: What Gaussian blur should be applied to the segmented image (used for quad detection?)
     * Parameter is the standard deviation in pixels.  Very noisy images benefit from non-zero values (e.g. 0.8). (default 0.0)
     * - detectInvertedMarker: to check if there is a white marker. In order to generate a "white" marker just
     * invert a normal marker by using a tilde, ~markerImage. (default false)
     */

    public class DetectorParameters : DisposableOpenCVObject
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
                        aruco_DetectorParameters_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal DetectorParameters(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static DetectorParameters __fromPtr__(IntPtr addr) { return new DetectorParameters(addr); }

        //
        // C++: static Ptr_DetectorParameters cv::aruco::DetectorParameters::create()
        //

        public static DetectorParameters create()
        {


            return DetectorParameters.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(aruco_DetectorParameters_create_10()));


        }


        //
        // C++: static bool cv::aruco::DetectorParameters::readDetectorParameters(FileNode fn, Ptr_DetectorParameters _params)
        //

        // Unknown type 'FileNode' (I), skipping the function


        //
        // C++: int DetectorParameters::adaptiveThreshWinSizeMin
        //

        public int get_adaptiveThreshWinSizeMin()
        {
            ThrowIfDisposed();

            return aruco_DetectorParameters_get_1adaptiveThreshWinSizeMin_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::adaptiveThreshWinSizeMin
        //

        public void set_adaptiveThreshWinSizeMin(int adaptiveThreshWinSizeMin)
        {
            ThrowIfDisposed();

            aruco_DetectorParameters_set_1adaptiveThreshWinSizeMin_10(nativeObj, adaptiveThreshWinSizeMin);


        }


        //
        // C++: int DetectorParameters::adaptiveThreshWinSizeMax
        //

        public int get_adaptiveThreshWinSizeMax()
        {
            ThrowIfDisposed();

            return aruco_DetectorParameters_get_1adaptiveThreshWinSizeMax_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::adaptiveThreshWinSizeMax
        //

        public void set_adaptiveThreshWinSizeMax(int adaptiveThreshWinSizeMax)
        {
            ThrowIfDisposed();

            aruco_DetectorParameters_set_1adaptiveThreshWinSizeMax_10(nativeObj, adaptiveThreshWinSizeMax);


        }


        //
        // C++: int DetectorParameters::adaptiveThreshWinSizeStep
        //

        public int get_adaptiveThreshWinSizeStep()
        {
            ThrowIfDisposed();

            return aruco_DetectorParameters_get_1adaptiveThreshWinSizeStep_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::adaptiveThreshWinSizeStep
        //

        public void set_adaptiveThreshWinSizeStep(int adaptiveThreshWinSizeStep)
        {
            ThrowIfDisposed();

            aruco_DetectorParameters_set_1adaptiveThreshWinSizeStep_10(nativeObj, adaptiveThreshWinSizeStep);


        }


        //
        // C++: double DetectorParameters::adaptiveThreshConstant
        //

        public double get_adaptiveThreshConstant()
        {
            ThrowIfDisposed();

            return aruco_DetectorParameters_get_1adaptiveThreshConstant_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::adaptiveThreshConstant
        //

        public void set_adaptiveThreshConstant(double adaptiveThreshConstant)
        {
            ThrowIfDisposed();

            aruco_DetectorParameters_set_1adaptiveThreshConstant_10(nativeObj, adaptiveThreshConstant);


        }


        //
        // C++: double DetectorParameters::minMarkerPerimeterRate
        //

        public double get_minMarkerPerimeterRate()
        {
            ThrowIfDisposed();

            return aruco_DetectorParameters_get_1minMarkerPerimeterRate_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::minMarkerPerimeterRate
        //

        public void set_minMarkerPerimeterRate(double minMarkerPerimeterRate)
        {
            ThrowIfDisposed();

            aruco_DetectorParameters_set_1minMarkerPerimeterRate_10(nativeObj, minMarkerPerimeterRate);


        }


        //
        // C++: double DetectorParameters::maxMarkerPerimeterRate
        //

        public double get_maxMarkerPerimeterRate()
        {
            ThrowIfDisposed();

            return aruco_DetectorParameters_get_1maxMarkerPerimeterRate_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::maxMarkerPerimeterRate
        //

        public void set_maxMarkerPerimeterRate(double maxMarkerPerimeterRate)
        {
            ThrowIfDisposed();

            aruco_DetectorParameters_set_1maxMarkerPerimeterRate_10(nativeObj, maxMarkerPerimeterRate);


        }


        //
        // C++: double DetectorParameters::polygonalApproxAccuracyRate
        //

        public double get_polygonalApproxAccuracyRate()
        {
            ThrowIfDisposed();

            return aruco_DetectorParameters_get_1polygonalApproxAccuracyRate_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::polygonalApproxAccuracyRate
        //

        public void set_polygonalApproxAccuracyRate(double polygonalApproxAccuracyRate)
        {
            ThrowIfDisposed();

            aruco_DetectorParameters_set_1polygonalApproxAccuracyRate_10(nativeObj, polygonalApproxAccuracyRate);


        }


        //
        // C++: double DetectorParameters::minCornerDistanceRate
        //

        public double get_minCornerDistanceRate()
        {
            ThrowIfDisposed();

            return aruco_DetectorParameters_get_1minCornerDistanceRate_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::minCornerDistanceRate
        //

        public void set_minCornerDistanceRate(double minCornerDistanceRate)
        {
            ThrowIfDisposed();

            aruco_DetectorParameters_set_1minCornerDistanceRate_10(nativeObj, minCornerDistanceRate);


        }


        //
        // C++: int DetectorParameters::minDistanceToBorder
        //

        public int get_minDistanceToBorder()
        {
            ThrowIfDisposed();

            return aruco_DetectorParameters_get_1minDistanceToBorder_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::minDistanceToBorder
        //

        public void set_minDistanceToBorder(int minDistanceToBorder)
        {
            ThrowIfDisposed();

            aruco_DetectorParameters_set_1minDistanceToBorder_10(nativeObj, minDistanceToBorder);


        }


        //
        // C++: double DetectorParameters::minMarkerDistanceRate
        //

        public double get_minMarkerDistanceRate()
        {
            ThrowIfDisposed();

            return aruco_DetectorParameters_get_1minMarkerDistanceRate_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::minMarkerDistanceRate
        //

        public void set_minMarkerDistanceRate(double minMarkerDistanceRate)
        {
            ThrowIfDisposed();

            aruco_DetectorParameters_set_1minMarkerDistanceRate_10(nativeObj, minMarkerDistanceRate);


        }


        //
        // C++: int DetectorParameters::cornerRefinementMethod
        //

        public int get_cornerRefinementMethod()
        {
            ThrowIfDisposed();

            return aruco_DetectorParameters_get_1cornerRefinementMethod_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::cornerRefinementMethod
        //

        public void set_cornerRefinementMethod(int cornerRefinementMethod)
        {
            ThrowIfDisposed();

            aruco_DetectorParameters_set_1cornerRefinementMethod_10(nativeObj, cornerRefinementMethod);


        }


        //
        // C++: int DetectorParameters::cornerRefinementWinSize
        //

        public int get_cornerRefinementWinSize()
        {
            ThrowIfDisposed();

            return aruco_DetectorParameters_get_1cornerRefinementWinSize_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::cornerRefinementWinSize
        //

        public void set_cornerRefinementWinSize(int cornerRefinementWinSize)
        {
            ThrowIfDisposed();

            aruco_DetectorParameters_set_1cornerRefinementWinSize_10(nativeObj, cornerRefinementWinSize);


        }


        //
        // C++: int DetectorParameters::cornerRefinementMaxIterations
        //

        public int get_cornerRefinementMaxIterations()
        {
            ThrowIfDisposed();

            return aruco_DetectorParameters_get_1cornerRefinementMaxIterations_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::cornerRefinementMaxIterations
        //

        public void set_cornerRefinementMaxIterations(int cornerRefinementMaxIterations)
        {
            ThrowIfDisposed();

            aruco_DetectorParameters_set_1cornerRefinementMaxIterations_10(nativeObj, cornerRefinementMaxIterations);


        }


        //
        // C++: double DetectorParameters::cornerRefinementMinAccuracy
        //

        public double get_cornerRefinementMinAccuracy()
        {
            ThrowIfDisposed();

            return aruco_DetectorParameters_get_1cornerRefinementMinAccuracy_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::cornerRefinementMinAccuracy
        //

        public void set_cornerRefinementMinAccuracy(double cornerRefinementMinAccuracy)
        {
            ThrowIfDisposed();

            aruco_DetectorParameters_set_1cornerRefinementMinAccuracy_10(nativeObj, cornerRefinementMinAccuracy);


        }


        //
        // C++: int DetectorParameters::markerBorderBits
        //

        public int get_markerBorderBits()
        {
            ThrowIfDisposed();

            return aruco_DetectorParameters_get_1markerBorderBits_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::markerBorderBits
        //

        public void set_markerBorderBits(int markerBorderBits)
        {
            ThrowIfDisposed();

            aruco_DetectorParameters_set_1markerBorderBits_10(nativeObj, markerBorderBits);


        }


        //
        // C++: int DetectorParameters::perspectiveRemovePixelPerCell
        //

        public int get_perspectiveRemovePixelPerCell()
        {
            ThrowIfDisposed();

            return aruco_DetectorParameters_get_1perspectiveRemovePixelPerCell_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::perspectiveRemovePixelPerCell
        //

        public void set_perspectiveRemovePixelPerCell(int perspectiveRemovePixelPerCell)
        {
            ThrowIfDisposed();

            aruco_DetectorParameters_set_1perspectiveRemovePixelPerCell_10(nativeObj, perspectiveRemovePixelPerCell);


        }


        //
        // C++: double DetectorParameters::perspectiveRemoveIgnoredMarginPerCell
        //

        public double get_perspectiveRemoveIgnoredMarginPerCell()
        {
            ThrowIfDisposed();

            return aruco_DetectorParameters_get_1perspectiveRemoveIgnoredMarginPerCell_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::perspectiveRemoveIgnoredMarginPerCell
        //

        public void set_perspectiveRemoveIgnoredMarginPerCell(double perspectiveRemoveIgnoredMarginPerCell)
        {
            ThrowIfDisposed();

            aruco_DetectorParameters_set_1perspectiveRemoveIgnoredMarginPerCell_10(nativeObj, perspectiveRemoveIgnoredMarginPerCell);


        }


        //
        // C++: double DetectorParameters::maxErroneousBitsInBorderRate
        //

        public double get_maxErroneousBitsInBorderRate()
        {
            ThrowIfDisposed();

            return aruco_DetectorParameters_get_1maxErroneousBitsInBorderRate_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::maxErroneousBitsInBorderRate
        //

        public void set_maxErroneousBitsInBorderRate(double maxErroneousBitsInBorderRate)
        {
            ThrowIfDisposed();

            aruco_DetectorParameters_set_1maxErroneousBitsInBorderRate_10(nativeObj, maxErroneousBitsInBorderRate);


        }


        //
        // C++: double DetectorParameters::minOtsuStdDev
        //

        public double get_minOtsuStdDev()
        {
            ThrowIfDisposed();

            return aruco_DetectorParameters_get_1minOtsuStdDev_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::minOtsuStdDev
        //

        public void set_minOtsuStdDev(double minOtsuStdDev)
        {
            ThrowIfDisposed();

            aruco_DetectorParameters_set_1minOtsuStdDev_10(nativeObj, minOtsuStdDev);


        }


        //
        // C++: double DetectorParameters::errorCorrectionRate
        //

        public double get_errorCorrectionRate()
        {
            ThrowIfDisposed();

            return aruco_DetectorParameters_get_1errorCorrectionRate_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::errorCorrectionRate
        //

        public void set_errorCorrectionRate(double errorCorrectionRate)
        {
            ThrowIfDisposed();

            aruco_DetectorParameters_set_1errorCorrectionRate_10(nativeObj, errorCorrectionRate);


        }


        //
        // C++: float DetectorParameters::aprilTagQuadDecimate
        //

        public float get_aprilTagQuadDecimate()
        {
            ThrowIfDisposed();

            return aruco_DetectorParameters_get_1aprilTagQuadDecimate_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::aprilTagQuadDecimate
        //

        public void set_aprilTagQuadDecimate(float aprilTagQuadDecimate)
        {
            ThrowIfDisposed();

            aruco_DetectorParameters_set_1aprilTagQuadDecimate_10(nativeObj, aprilTagQuadDecimate);


        }


        //
        // C++: float DetectorParameters::aprilTagQuadSigma
        //

        public float get_aprilTagQuadSigma()
        {
            ThrowIfDisposed();

            return aruco_DetectorParameters_get_1aprilTagQuadSigma_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::aprilTagQuadSigma
        //

        public void set_aprilTagQuadSigma(float aprilTagQuadSigma)
        {
            ThrowIfDisposed();

            aruco_DetectorParameters_set_1aprilTagQuadSigma_10(nativeObj, aprilTagQuadSigma);


        }


        //
        // C++: int DetectorParameters::aprilTagMinClusterPixels
        //

        public int get_aprilTagMinClusterPixels()
        {
            ThrowIfDisposed();

            return aruco_DetectorParameters_get_1aprilTagMinClusterPixels_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::aprilTagMinClusterPixels
        //

        public void set_aprilTagMinClusterPixels(int aprilTagMinClusterPixels)
        {
            ThrowIfDisposed();

            aruco_DetectorParameters_set_1aprilTagMinClusterPixels_10(nativeObj, aprilTagMinClusterPixels);


        }


        //
        // C++: int DetectorParameters::aprilTagMaxNmaxima
        //

        public int get_aprilTagMaxNmaxima()
        {
            ThrowIfDisposed();

            return aruco_DetectorParameters_get_1aprilTagMaxNmaxima_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::aprilTagMaxNmaxima
        //

        public void set_aprilTagMaxNmaxima(int aprilTagMaxNmaxima)
        {
            ThrowIfDisposed();

            aruco_DetectorParameters_set_1aprilTagMaxNmaxima_10(nativeObj, aprilTagMaxNmaxima);


        }


        //
        // C++: float DetectorParameters::aprilTagCriticalRad
        //

        public float get_aprilTagCriticalRad()
        {
            ThrowIfDisposed();

            return aruco_DetectorParameters_get_1aprilTagCriticalRad_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::aprilTagCriticalRad
        //

        public void set_aprilTagCriticalRad(float aprilTagCriticalRad)
        {
            ThrowIfDisposed();

            aruco_DetectorParameters_set_1aprilTagCriticalRad_10(nativeObj, aprilTagCriticalRad);


        }


        //
        // C++: float DetectorParameters::aprilTagMaxLineFitMse
        //

        public float get_aprilTagMaxLineFitMse()
        {
            ThrowIfDisposed();

            return aruco_DetectorParameters_get_1aprilTagMaxLineFitMse_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::aprilTagMaxLineFitMse
        //

        public void set_aprilTagMaxLineFitMse(float aprilTagMaxLineFitMse)
        {
            ThrowIfDisposed();

            aruco_DetectorParameters_set_1aprilTagMaxLineFitMse_10(nativeObj, aprilTagMaxLineFitMse);


        }


        //
        // C++: int DetectorParameters::aprilTagMinWhiteBlackDiff
        //

        public int get_aprilTagMinWhiteBlackDiff()
        {
            ThrowIfDisposed();

            return aruco_DetectorParameters_get_1aprilTagMinWhiteBlackDiff_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::aprilTagMinWhiteBlackDiff
        //

        public void set_aprilTagMinWhiteBlackDiff(int aprilTagMinWhiteBlackDiff)
        {
            ThrowIfDisposed();

            aruco_DetectorParameters_set_1aprilTagMinWhiteBlackDiff_10(nativeObj, aprilTagMinWhiteBlackDiff);


        }


        //
        // C++: int DetectorParameters::aprilTagDeglitch
        //

        public int get_aprilTagDeglitch()
        {
            ThrowIfDisposed();

            return aruco_DetectorParameters_get_1aprilTagDeglitch_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::aprilTagDeglitch
        //

        public void set_aprilTagDeglitch(int aprilTagDeglitch)
        {
            ThrowIfDisposed();

            aruco_DetectorParameters_set_1aprilTagDeglitch_10(nativeObj, aprilTagDeglitch);


        }


        //
        // C++: bool DetectorParameters::detectInvertedMarker
        //

        public bool get_detectInvertedMarker()
        {
            ThrowIfDisposed();

            return aruco_DetectorParameters_get_1detectInvertedMarker_10(nativeObj);


        }


        //
        // C++: void DetectorParameters::detectInvertedMarker
        //

        public void set_detectInvertedMarker(bool detectInvertedMarker)
        {
            ThrowIfDisposed();

            aruco_DetectorParameters_set_1detectInvertedMarker_10(nativeObj, detectInvertedMarker);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_DetectorParameters cv::aruco::DetectorParameters::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_DetectorParameters_create_10();

        // C++: int DetectorParameters::adaptiveThreshWinSizeMin
        [DllImport(LIBNAME)]
        private static extern int aruco_DetectorParameters_get_1adaptiveThreshWinSizeMin_10(IntPtr nativeObj);

        // C++: void DetectorParameters::adaptiveThreshWinSizeMin
        [DllImport(LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1adaptiveThreshWinSizeMin_10(IntPtr nativeObj, int adaptiveThreshWinSizeMin);

        // C++: int DetectorParameters::adaptiveThreshWinSizeMax
        [DllImport(LIBNAME)]
        private static extern int aruco_DetectorParameters_get_1adaptiveThreshWinSizeMax_10(IntPtr nativeObj);

        // C++: void DetectorParameters::adaptiveThreshWinSizeMax
        [DllImport(LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1adaptiveThreshWinSizeMax_10(IntPtr nativeObj, int adaptiveThreshWinSizeMax);

        // C++: int DetectorParameters::adaptiveThreshWinSizeStep
        [DllImport(LIBNAME)]
        private static extern int aruco_DetectorParameters_get_1adaptiveThreshWinSizeStep_10(IntPtr nativeObj);

        // C++: void DetectorParameters::adaptiveThreshWinSizeStep
        [DllImport(LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1adaptiveThreshWinSizeStep_10(IntPtr nativeObj, int adaptiveThreshWinSizeStep);

        // C++: double DetectorParameters::adaptiveThreshConstant
        [DllImport(LIBNAME)]
        private static extern double aruco_DetectorParameters_get_1adaptiveThreshConstant_10(IntPtr nativeObj);

        // C++: void DetectorParameters::adaptiveThreshConstant
        [DllImport(LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1adaptiveThreshConstant_10(IntPtr nativeObj, double adaptiveThreshConstant);

        // C++: double DetectorParameters::minMarkerPerimeterRate
        [DllImport(LIBNAME)]
        private static extern double aruco_DetectorParameters_get_1minMarkerPerimeterRate_10(IntPtr nativeObj);

        // C++: void DetectorParameters::minMarkerPerimeterRate
        [DllImport(LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1minMarkerPerimeterRate_10(IntPtr nativeObj, double minMarkerPerimeterRate);

        // C++: double DetectorParameters::maxMarkerPerimeterRate
        [DllImport(LIBNAME)]
        private static extern double aruco_DetectorParameters_get_1maxMarkerPerimeterRate_10(IntPtr nativeObj);

        // C++: void DetectorParameters::maxMarkerPerimeterRate
        [DllImport(LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1maxMarkerPerimeterRate_10(IntPtr nativeObj, double maxMarkerPerimeterRate);

        // C++: double DetectorParameters::polygonalApproxAccuracyRate
        [DllImport(LIBNAME)]
        private static extern double aruco_DetectorParameters_get_1polygonalApproxAccuracyRate_10(IntPtr nativeObj);

        // C++: void DetectorParameters::polygonalApproxAccuracyRate
        [DllImport(LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1polygonalApproxAccuracyRate_10(IntPtr nativeObj, double polygonalApproxAccuracyRate);

        // C++: double DetectorParameters::minCornerDistanceRate
        [DllImport(LIBNAME)]
        private static extern double aruco_DetectorParameters_get_1minCornerDistanceRate_10(IntPtr nativeObj);

        // C++: void DetectorParameters::minCornerDistanceRate
        [DllImport(LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1minCornerDistanceRate_10(IntPtr nativeObj, double minCornerDistanceRate);

        // C++: int DetectorParameters::minDistanceToBorder
        [DllImport(LIBNAME)]
        private static extern int aruco_DetectorParameters_get_1minDistanceToBorder_10(IntPtr nativeObj);

        // C++: void DetectorParameters::minDistanceToBorder
        [DllImport(LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1minDistanceToBorder_10(IntPtr nativeObj, int minDistanceToBorder);

        // C++: double DetectorParameters::minMarkerDistanceRate
        [DllImport(LIBNAME)]
        private static extern double aruco_DetectorParameters_get_1minMarkerDistanceRate_10(IntPtr nativeObj);

        // C++: void DetectorParameters::minMarkerDistanceRate
        [DllImport(LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1minMarkerDistanceRate_10(IntPtr nativeObj, double minMarkerDistanceRate);

        // C++: int DetectorParameters::cornerRefinementMethod
        [DllImport(LIBNAME)]
        private static extern int aruco_DetectorParameters_get_1cornerRefinementMethod_10(IntPtr nativeObj);

        // C++: void DetectorParameters::cornerRefinementMethod
        [DllImport(LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1cornerRefinementMethod_10(IntPtr nativeObj, int cornerRefinementMethod);

        // C++: int DetectorParameters::cornerRefinementWinSize
        [DllImport(LIBNAME)]
        private static extern int aruco_DetectorParameters_get_1cornerRefinementWinSize_10(IntPtr nativeObj);

        // C++: void DetectorParameters::cornerRefinementWinSize
        [DllImport(LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1cornerRefinementWinSize_10(IntPtr nativeObj, int cornerRefinementWinSize);

        // C++: int DetectorParameters::cornerRefinementMaxIterations
        [DllImport(LIBNAME)]
        private static extern int aruco_DetectorParameters_get_1cornerRefinementMaxIterations_10(IntPtr nativeObj);

        // C++: void DetectorParameters::cornerRefinementMaxIterations
        [DllImport(LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1cornerRefinementMaxIterations_10(IntPtr nativeObj, int cornerRefinementMaxIterations);

        // C++: double DetectorParameters::cornerRefinementMinAccuracy
        [DllImport(LIBNAME)]
        private static extern double aruco_DetectorParameters_get_1cornerRefinementMinAccuracy_10(IntPtr nativeObj);

        // C++: void DetectorParameters::cornerRefinementMinAccuracy
        [DllImport(LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1cornerRefinementMinAccuracy_10(IntPtr nativeObj, double cornerRefinementMinAccuracy);

        // C++: int DetectorParameters::markerBorderBits
        [DllImport(LIBNAME)]
        private static extern int aruco_DetectorParameters_get_1markerBorderBits_10(IntPtr nativeObj);

        // C++: void DetectorParameters::markerBorderBits
        [DllImport(LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1markerBorderBits_10(IntPtr nativeObj, int markerBorderBits);

        // C++: int DetectorParameters::perspectiveRemovePixelPerCell
        [DllImport(LIBNAME)]
        private static extern int aruco_DetectorParameters_get_1perspectiveRemovePixelPerCell_10(IntPtr nativeObj);

        // C++: void DetectorParameters::perspectiveRemovePixelPerCell
        [DllImport(LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1perspectiveRemovePixelPerCell_10(IntPtr nativeObj, int perspectiveRemovePixelPerCell);

        // C++: double DetectorParameters::perspectiveRemoveIgnoredMarginPerCell
        [DllImport(LIBNAME)]
        private static extern double aruco_DetectorParameters_get_1perspectiveRemoveIgnoredMarginPerCell_10(IntPtr nativeObj);

        // C++: void DetectorParameters::perspectiveRemoveIgnoredMarginPerCell
        [DllImport(LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1perspectiveRemoveIgnoredMarginPerCell_10(IntPtr nativeObj, double perspectiveRemoveIgnoredMarginPerCell);

        // C++: double DetectorParameters::maxErroneousBitsInBorderRate
        [DllImport(LIBNAME)]
        private static extern double aruco_DetectorParameters_get_1maxErroneousBitsInBorderRate_10(IntPtr nativeObj);

        // C++: void DetectorParameters::maxErroneousBitsInBorderRate
        [DllImport(LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1maxErroneousBitsInBorderRate_10(IntPtr nativeObj, double maxErroneousBitsInBorderRate);

        // C++: double DetectorParameters::minOtsuStdDev
        [DllImport(LIBNAME)]
        private static extern double aruco_DetectorParameters_get_1minOtsuStdDev_10(IntPtr nativeObj);

        // C++: void DetectorParameters::minOtsuStdDev
        [DllImport(LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1minOtsuStdDev_10(IntPtr nativeObj, double minOtsuStdDev);

        // C++: double DetectorParameters::errorCorrectionRate
        [DllImport(LIBNAME)]
        private static extern double aruco_DetectorParameters_get_1errorCorrectionRate_10(IntPtr nativeObj);

        // C++: void DetectorParameters::errorCorrectionRate
        [DllImport(LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1errorCorrectionRate_10(IntPtr nativeObj, double errorCorrectionRate);

        // C++: float DetectorParameters::aprilTagQuadDecimate
        [DllImport(LIBNAME)]
        private static extern float aruco_DetectorParameters_get_1aprilTagQuadDecimate_10(IntPtr nativeObj);

        // C++: void DetectorParameters::aprilTagQuadDecimate
        [DllImport(LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1aprilTagQuadDecimate_10(IntPtr nativeObj, float aprilTagQuadDecimate);

        // C++: float DetectorParameters::aprilTagQuadSigma
        [DllImport(LIBNAME)]
        private static extern float aruco_DetectorParameters_get_1aprilTagQuadSigma_10(IntPtr nativeObj);

        // C++: void DetectorParameters::aprilTagQuadSigma
        [DllImport(LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1aprilTagQuadSigma_10(IntPtr nativeObj, float aprilTagQuadSigma);

        // C++: int DetectorParameters::aprilTagMinClusterPixels
        [DllImport(LIBNAME)]
        private static extern int aruco_DetectorParameters_get_1aprilTagMinClusterPixels_10(IntPtr nativeObj);

        // C++: void DetectorParameters::aprilTagMinClusterPixels
        [DllImport(LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1aprilTagMinClusterPixels_10(IntPtr nativeObj, int aprilTagMinClusterPixels);

        // C++: int DetectorParameters::aprilTagMaxNmaxima
        [DllImport(LIBNAME)]
        private static extern int aruco_DetectorParameters_get_1aprilTagMaxNmaxima_10(IntPtr nativeObj);

        // C++: void DetectorParameters::aprilTagMaxNmaxima
        [DllImport(LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1aprilTagMaxNmaxima_10(IntPtr nativeObj, int aprilTagMaxNmaxima);

        // C++: float DetectorParameters::aprilTagCriticalRad
        [DllImport(LIBNAME)]
        private static extern float aruco_DetectorParameters_get_1aprilTagCriticalRad_10(IntPtr nativeObj);

        // C++: void DetectorParameters::aprilTagCriticalRad
        [DllImport(LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1aprilTagCriticalRad_10(IntPtr nativeObj, float aprilTagCriticalRad);

        // C++: float DetectorParameters::aprilTagMaxLineFitMse
        [DllImport(LIBNAME)]
        private static extern float aruco_DetectorParameters_get_1aprilTagMaxLineFitMse_10(IntPtr nativeObj);

        // C++: void DetectorParameters::aprilTagMaxLineFitMse
        [DllImport(LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1aprilTagMaxLineFitMse_10(IntPtr nativeObj, float aprilTagMaxLineFitMse);

        // C++: int DetectorParameters::aprilTagMinWhiteBlackDiff
        [DllImport(LIBNAME)]
        private static extern int aruco_DetectorParameters_get_1aprilTagMinWhiteBlackDiff_10(IntPtr nativeObj);

        // C++: void DetectorParameters::aprilTagMinWhiteBlackDiff
        [DllImport(LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1aprilTagMinWhiteBlackDiff_10(IntPtr nativeObj, int aprilTagMinWhiteBlackDiff);

        // C++: int DetectorParameters::aprilTagDeglitch
        [DllImport(LIBNAME)]
        private static extern int aruco_DetectorParameters_get_1aprilTagDeglitch_10(IntPtr nativeObj);

        // C++: void DetectorParameters::aprilTagDeglitch
        [DllImport(LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1aprilTagDeglitch_10(IntPtr nativeObj, int aprilTagDeglitch);

        // C++: bool DetectorParameters::detectInvertedMarker
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool aruco_DetectorParameters_get_1detectInvertedMarker_10(IntPtr nativeObj);

        // C++: void DetectorParameters::detectInvertedMarker
        [DllImport(LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1detectInvertedMarker_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool detectInvertedMarker);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void aruco_DetectorParameters_delete(IntPtr nativeObj);

    }
}
