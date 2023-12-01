using System.Reflection.Emit;

namespace Embedder.Datasets
{
    public class Pair
    {
        public string FirstPair { get;set; }
        public string SecondPair { get;set; }
        public int Label { get;set; }

        public Pair(string firstPair, string secondPair, int label) =>
            (FirstPair, SecondPair, Label) = (firstPair, secondPair, label);
        public static Pair Create(string firstPair, string secondPair, string label) =>
            new Pair(firstPair, secondPair, int.Parse(label));
    }
}
