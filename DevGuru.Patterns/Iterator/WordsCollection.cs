using System.Collections.Generic;

namespace DevGuru.Patterns.Iterator
{
    public class WordsCollection : IteratorAggregate
    {
        private readonly List<string> collection = new();
        private bool direction = false;

        public int Count { get => collection.Count; }

        public override string this[int index] => collection[index];

        public void Add(string item) => collection.Add(item);

        public override IEnumerator<string> GetEnumerator() => new AlphabeticalOrderIterator(this, direction);

        public void Reverse() => direction = !direction;
    }
}
