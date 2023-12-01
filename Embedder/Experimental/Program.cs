using Embedder.Datasets;
using Embedder.Datasets.Extensions;

Dataset dataset = DatasetSpliter.Split(DatasetLoader.Load("Datasets/Data/train.csv"));

dataset.PrintPreview();
