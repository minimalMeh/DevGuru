using System.Collections.Generic;

namespace DevGuru.Core.Iterator
{
    public class WordsCollection : IteratorAggregate
    {
        private List<string> collection = new List<string>();
        private bool direction = false;

        public int Count { get => collection.Count; }

        public override string this[int index] => collection[index];

        public void Add(string item) => collection.Add(item);

        public override IEnumerator<string> GetEnumerator() => new AlphabeticalOrderIterator(this, direction);

        public void Reverse() => direction = true;
    }
}
