string modelImagePath = "...";
string queryImagePath = "...";

Mat modelImage = ImagePreprocessor.Preprocess(modelImagePath);
(VectorOfKeyPoint modelKeyPoints, Mat modelDescriptors) = FeatureExtractor.ExtractFeatures(modelImage);

Mat queryImage = ImagePreprocessor.Preprocess(queryImagePath);
(VectorOfKeyPoint queryKeyPoints, Mat queryDescriptors) = FeatureExtractor.ExtractFeatures(queryImage);

VectorOfDMatch matches = FeatureMatcher.Match(modelDescriptors, queryDescriptors);

float score = ResultSorter.SortAndReturn(matches);