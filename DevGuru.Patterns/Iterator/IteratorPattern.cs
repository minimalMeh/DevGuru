using DevGuru.Core;
using System;

namespace DevGuru.Patterns.Iterator
{
    public class IteratorPattern : PatternBase
    {
        public override string Name => "Iterator";
        protected override string DescriptionFormatted => "\t[Provides a way to access the elements of an aggregate object sequentially without exposing its]\n\t[underlying representation, allowing for different ways to traverse the collection.]\n";
        protected override string IdeaFormatted => "\t[You might want to iterate through a collection of words back and forth.]\n\t[WordsCollection is an IEnumerable, and AlphabeticalOrderIterator is an IEnumerator.]\n";

        protected override void RunCore()
        {
            var collection = new WordsCollection
            {
                "First",
                "Second",
                "Third"
            };

            Console.WriteLine("Direct:");

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nReverse:");

            collection.Reverse();

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
        }
    }
}
