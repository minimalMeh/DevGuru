using DevGuru.Patterns.Strategy.Interfaces;
using System;
using System.Collections.Generic;

namespace DevGuru.Patterns.Strategy
{
    public class SortMachine<T> where T : IComparable
    {
        private ISortStrategy<T> strategy;

        public void SetStrategy(ISortStrategy<T> strategy)
        {
            this.strategy = strategy;
        }

        public void Sort(IEnumerable<T> data)
        {
            var sorted = strategy?.Sort(data);
            foreach (var i in sorted)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
        }
    }
}
