using System;
using System.Collections.Generic;
using System.Text;
using DevGuru.Core.Strategy.Interfaces;

namespace DevGuru.Core.Strategy
{
    public class SortMachine<T> where T: IComparable
    {
        private ISortStrategy<T> strategy;

        public void SetStrategy(ISortStrategy<T> strategy)
        {
            this.strategy = strategy;
        }

        public void Sort(IEnumerable<T> data)
        {
            var sorted =  strategy?.Sort(data);
            foreach(var i in sorted)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
        }
    }
}
