using System;
using System.Collections.Generic;

namespace DevGuru.Patterns.Strategy.Interfaces
{
    public interface ISortingStrategy<T> where T : IComparable
    {
        IEnumerable<T> Sort(IEnumerable<T> data);
    }
}
