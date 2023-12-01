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
            StringBuilder previewBuilder = new StringBuilder();

            previewBuilder.AppendLine("\nTotal Train Samples: " + dataset.Train.Count);
            previewBuilder.AppendLine("Total Validation Samples: " + dataset.Validation.Count);
            previewBuilder.AppendLine("Total Test Samples: " + dataset.Test.Count);

            previewBuilder.AppendLine("\nTotal Samples: " + (dataset.Test.Count + dataset.Train.Count + dataset.Validation.Count));

            Console.WriteLine(previewBuilder.ToString());
        }
    }
}
