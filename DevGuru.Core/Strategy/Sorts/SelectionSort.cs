using System;
using System.Collections.Generic;
using System.Linq;
using DevGuru.Core.Strategy.Helpers;
using DevGuru.Core.Strategy.Interfaces;

namespace DevGuru.Core.Strategy.Concrete
{
    public class SelectionSort<T> : ISortStrategy<T> where T : IComparable
    {
        public IEnumerable<T> Sort(IEnumerable<T> data)
        {
            var n = data.Count();

            for (int i = 0; i < n - 1; i++)
            {
                int smallest = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (data.ElementAt(j).CompareTo(data.ElementAt(smallest)) > 0)
                    {
                        smallest = j;
                    }
                }

                data = data.Swap(smallest, i);
            }

            return data;
        }
    }
}
