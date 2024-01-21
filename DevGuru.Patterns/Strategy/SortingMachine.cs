using DevGuru.Patterns.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevGuru.Patterns.Strategy
{
    public class SortingMachine<T> where T : IComparable
    {
        private ISortingStrategy<T> strategy;

        public void SetStrategy(ISortingStrategy<T> strategy)
        {
            Console.WriteLine($"Change a strategy {this.strategy?.GetType().Name ?? ""} to {strategy.GetType().Name}.");
            this.strategy = strategy;
        }

        public void Sort(IEnumerable<T> data)
        {
            Console.WriteLine("Unsorted array:");
            Console.Write('[' + string.Join(", ", data) + ']');
            Console.WriteLine();


            var sorted = strategy?.Sort(data)?.ToList();
            Console.WriteLine("Sorted array:");
            Console.Write('[' + string.Join(", ", sorted) + ']');

            Console.WriteLine();
        }
    }
}
