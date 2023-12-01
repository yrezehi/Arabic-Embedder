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

            previewBuilder.AppendLine("Total Samples: " + (dataset.Test.Count + dataset.Train.Count + dataset.Validation.Count));

            Console.WriteLine(previewBuilder.ToString());
        }

        public static void PrintDiversity(this Dataset dataset)
        {
            StringBuilder diversityBuilder = new StringBuilder();

            diversityBuilder.AppendLine("\nTotal Positive Samples: " + dataset.Unsplit().Count(set => set.Label == 1));
            diversityBuilder.AppendLine("Total Negative Samples: " + dataset.Unsplit().Count(set => set.Label == 0));

            Console.WriteLine(diversityBuilder.ToString());
        }

        public static void PrintTrainDiversity(this Dataset dataset)
        {
            StringBuilder diversityBuilder = new StringBuilder();

            diversityBuilder.AppendLine("\nTotal Train Positive Samples: " + dataset.Train.Count(set => set.Label == 1));
            diversityBuilder.AppendLine("Total Train Negative Samples: " + dataset.Train.Count(set => set.Label == 0));

            Console.WriteLine(diversityBuilder.ToString());
        }

        public static void PrintValidationDiversity(this Dataset dataset)
        {
            StringBuilder diversityBuilder = new StringBuilder();

            diversityBuilder.AppendLine("\nTotal Validation Positive Samples: " + dataset.Validation.Count(set => set.Label == 1));
            diversityBuilder.AppendLine("Total Validation Negative Samples: " + dataset.Validation.Count(set => set.Label == 0));

            Console.WriteLine(diversityBuilder.ToString());
        }

        public static void PrintTestDiversity(this Dataset dataset)
        {
            StringBuilder diversityBuilder = new StringBuilder();

            diversityBuilder.AppendLine("\nTotal Validation Positive Samples: " + dataset.Test.Count(set => set.Label == 1));
            diversityBuilder.AppendLine("Total Validation Negative Samples: " + dataset.Test.Count(set => set.Label == 0));

            Console.WriteLine(diversityBuilder.ToString());
        }
    }
}
