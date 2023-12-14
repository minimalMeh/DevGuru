using System.Collections;
using System.Collections.Generic;

namespace DevGuru.Patterns.Iterator
{
    public abstract class IteratorAggregate : IEnumerable<string>
    {
        public abstract string this[int index] { get; }

        public abstract IEnumerator<string> GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
