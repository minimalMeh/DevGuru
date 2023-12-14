using DevGuru.Patterns.Strategy.Helpers;
using DevGuru.Patterns.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevGuru.Patterns.Strategy.Concrete
{
    public class BubbleSort<T> : ISortStrategy<T> where T : IComparable
    {
        public IEnumerable<T> Sort(IEnumerable<T> data)
        {
            int n = data.Count();

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (data.ElementAt(j).CompareTo(data.ElementAt(j + 1)) > 0)
                    {
                        data = data.Swap(j, j + 1);
                    }
                }
            }

            return data;
        }
    }
}
