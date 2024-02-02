using System;

namespace DevGuru.Core
{
    public abstract class PatternBase : IPattern
    {
        public abstract string Name { get; }
        protected abstract string DescriptionFormatted { get; }
        protected abstract string IdeaFormatted { get; }

        protected abstract void RunCore();

        public void Run()
        {
            Console.WriteLine("/------------------------------------------------\\");

            ConsoleOutputIntro();

            ConsoleOutputIdea();

            ConsoleOutputRun();

            Console.WriteLine("\\------------------------------------------------/\n");
        }

        private void ConsoleOutputIntro()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"\t[{Name}]");
            Console.WriteLine(DescriptionFormatted);

            Console.ForegroundColor = ConsoleColor.White;
        }

        private void ConsoleOutputIdea()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine(IdeaFormatted);

            Console.ForegroundColor = ConsoleColor.White;
        }

        private void ConsoleOutputRun()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine($"\t[{Name}Pattern.cs   RunCore()]\n");

            Console.ForegroundColor = ConsoleColor.White;

            RunCore();
        }
    }
}
