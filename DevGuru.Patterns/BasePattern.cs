using DevGuru.Core;
using System;

namespace DevGuru.Patterns
{
    public abstract class BasePattern : IPattern
    {
        public abstract string Name { get; }
        public abstract string IdeaFormatted { get; }

        public abstract void RunCore();

        public void Run()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"\t[{Name}]");
            Console.WriteLine(IdeaFormatted);

            RunCore();

            Console.WriteLine("------------------------------------------------");
        }
    }
}
