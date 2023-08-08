// FeatureMatcher.cs
using Emgu.CV;
using Emgu.CV.Util;

public class FeatureMatcher
{
    public static VectorOfDMatch Match(Mat modelDescriptors, Mat queryDescriptors)
    {
        using (var matcher = new BFMatcher(DistanceType.L2))
        {
            VectorOfVectorOfDMatch matches = new VectorOfVectorOfDMatch();
            matcher.Add(modelDescriptors);
            matcher.KnnMatch(queryDescriptors, matches, 2, null);

            VectorOfDMatch goodMatches = new VectorOfDMatch();
            for (int i = 0; i < matches.Size; i++)
            {
                VectorOfDMatch match = matches[i];
                if (match.Size >= 2 && match[0].Distance < 0.75 * match[1].Distance)
                {
                    goodMatches.Push(new DMatch[] { match[0] });
                }
            }

            return goodMatches;
        }
    }
}
