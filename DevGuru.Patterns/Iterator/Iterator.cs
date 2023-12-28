using System;
using System.Collections;
using System.Collections.Generic;

namespace DevGuru.Patterns.Iterator
{
    public abstract class Iterator : IEnumerator<string>
    {
        public abstract string Current { get; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public abstract bool MoveNext();
        public abstract void Reset();
    }
}
