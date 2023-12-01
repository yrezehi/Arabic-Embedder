using Microsoft.VisualBasic.FileIO;

namespace Embedder.Datasets
{
    public class DatasetLoader
    {
        private string Path;

        private static string DELIMITERS = ",";

        public DatasetLoader(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException(path);
            }

            Path = path;
        }

        public IList<Pair> Load()
        {
            var pairs = new List<Pair>();

            using (TextFieldParser parser = new TextFieldParser(Path))
            {
                parser.SetDelimiters(DELIMITERS);
                parser.HasFieldsEnclosedInQuotes = true;

                parser.ReadLine();

                while (!parser.EndOfData)
                {
                    string[]? fields = parser.ReadFields();

                    if (fields != null && fields.Length > 2)
                    {
                        pairs.Add(Pair.Create(fields[0], fields[1], fields[2]));
                    }
                }
            }

            return pairs;
        }

        public static IList<Pair> Load(string path) =>
            new DatasetLoader(path).Load();
    }
}
