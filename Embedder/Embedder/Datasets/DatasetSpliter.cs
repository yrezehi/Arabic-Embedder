using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embedder.Datasets
{
    public class DatasetSpliter
    {
        public static Dataset Split(IList<Pair> unsplittedDataset)
        {
            Dataset dataset = Dataset.Instance();

            int trainLength = (int)Math.Round(unsplittedDataset.Count * .70);
            int validtionLength = (int)Math.Round(unsplittedDataset.Count * .20);

            dataset.Train = unsplittedDataset.Take(trainLength).ToList();
            dataset.Validation = unsplittedDataset.Skip(trainLength).Take(validtionLength - trainLength).ToList();
            dataset.Test = unsplittedDataset.Skip(validtionLength).ToList();

            return dataset;
        }
    }
}
