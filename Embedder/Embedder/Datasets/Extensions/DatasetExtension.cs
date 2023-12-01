using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embedder.Datasets.Extensions
{
    public static class DatasetExtension { 
    
        public static void PrintPreview(this Dataset dataset)
        {
            Console.WriteLine("Total Train Samples: " + dataset.Train.Count);
            Console.WriteLine("Total Validation Samples: " + dataset.Validation.Count);
            Console.WriteLine("Total Test Samples: " + dataset.Test.Count);
        }
    }
}
