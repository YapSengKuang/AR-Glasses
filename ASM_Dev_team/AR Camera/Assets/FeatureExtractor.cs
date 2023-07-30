// FeatureExtractor.cs
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.CV.XFeatures2D;

public class FeatureExtractor
{
    public static (VectorOfKeyPoint, Mat) ExtractFeatures(Mat image)
    {
        using (var sift = SIFT.Create())
        {
            VectorOfKeyPoint keyPoints = new VectorOfKeyPoint();
            Mat descriptors = new Mat();
            sift.DetectAndCompute(image, null, keyPoints, descriptors, false);

            return (keyPoints, descriptors);
        }
    }
}