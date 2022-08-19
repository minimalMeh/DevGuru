using System;
using System.Collections.Generic;

namespace DevGuru.Core.Strategy.Interfaces
{
    public interface ISortStrategy<T> where T: IComparable
    {
        IEnumerable<T> Sort(IEnumerable<T> data);
    }
}
