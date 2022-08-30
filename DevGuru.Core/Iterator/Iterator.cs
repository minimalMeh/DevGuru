﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DevGuru.Core.Iterator
{
    public abstract class Iterator : IEnumerator<string>
    {
        public abstract string Current { get; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            
        }

        public abstract bool MoveNext();
        public abstract void Reset();
    }
}