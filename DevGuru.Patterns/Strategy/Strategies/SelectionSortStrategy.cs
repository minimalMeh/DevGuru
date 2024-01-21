using DevGuru.Patterns.Strategy.Helpers;
using DevGuru.Patterns.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevGuru.Patterns.Strategy.Strategies
{
    public class SelectionSortStrategy<T> : ISortingStrategy<T> where T : IComparable
    {
        public IEnumerable<T> Sort(IEnumerable<T> data)
        {
            var length = data.Count();

            for (int i = 0; i < length - 1; i++)
            {
                int smallest = i;

                for (int j = i + 1; j < length; j++)
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
