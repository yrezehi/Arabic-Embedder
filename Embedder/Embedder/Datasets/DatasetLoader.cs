using Microsoft.VisualBasic.FileIO;

namespace Embedder.Datasets
{
    public class DatasetLoader
    {
        private string Path;

        private static string DELIMITERS = ",";

        public DatasetLoader(string path) =>
            Path = path;

        public IList<Pair> Load()
        {
            var pairs = new List<Pair>();

            using (TextFieldParser parser = new TextFieldParser)
            {
                parser.SetDelimiters(DELIMITERS);
                parser.HasFieldsEnclosedInQuotes = true;

                parser.ReadLine();

                while (!parser.EndOfData)
                {
                    pairs.Add(new Pair());
                }
            }
        }

        public static DatasetLoader Load(string path) =>
            new DatasetLoader(path);
      

    }
}
