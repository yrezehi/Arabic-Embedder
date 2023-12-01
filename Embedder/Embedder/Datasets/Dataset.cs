using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embedder.Datasets
{
    public class Dataset
    {
        public IList<Pair> Train;
        public IList<Pair> Validation;
        public IList<Pair> Test;

        public Dataset() { }
        public Dataset(IList<Pair> train, IList<Pair> validation, IList<Pair> test) =>
            (Train, Validation, Test) = (train, validation, test);

        public IList<Pair> Unsplit() =>
            Train.Concat(Validation).Concat(Test).ToList();

        public static Dataset Instance(IList<Pair> train, IList<Pair> validation, IList<Pair> test) =>
            new Dataset(train, validation, test);
        public static Dataset Instance() =>
            new Dataset();
    }
}
