using DevGuru.Core;
using DevGuru.Patterns.Strategy.Strategies;
using System;

namespace DevGuru.Patterns.Strategy
{
    public class StrategyPattern : PatternBase
    {
        public override string Name => "Strategy";
        protected override string DescriptionFormatted => "\t[Defines a family of algorithms, encapsulates each one, and makes them interchangeable,]\n\t[allowing the client to choose the appropriate algorithm at runtime.]\n";
        protected override string IdeaFormatted => "\t[A sorting machine uses different sort algorithms. Change a strategy of sorting.]\n";

        protected override void RunCore()
        {
            int[] numbers = { 89, 1, 2, 3, 12, 312, 312, 12, 2, 3, 34, 5, 35, 24, 23, 31, 24, 235, 346, 4, 2, 3, 4 };
            char[] chars = { 't', 'd', 'e', 'r', 'a', 'A', 'U', 'D', '<', 'm', 'q', 'T', 'v', 'E' };

            Console.WriteLine("\nNumbers:");
            var numberSortingMachine = new SortingMachine<int>();

            numberSortingMachine.SetStrategy(new BubbleSortStrategy<int>());
            numberSortingMachine.Sort(numbers);

            numberSortingMachine.SetStrategy(new SelectionSortStrategy<int>());
            numberSortingMachine.Sort(numbers);

            Console.WriteLine("\nChars:");
            var charSortingMachine = new SortingMachine<char>();

            charSortingMachine.SetStrategy(new BubbleSortStrategy<char>());
            charSortingMachine.Sort(chars);

            charSortingMachine.SetStrategy(new BubbleSortStrategy<char>());
            charSortingMachine.Sort(chars);
        }
    }
}
