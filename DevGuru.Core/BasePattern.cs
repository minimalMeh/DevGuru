using System;

namespace DevGuru.Core
{
    public abstract class BasePattern : IPattern
    {
        public abstract string Name { get; }
        protected abstract string DescriptionFormatted { get; }
        protected abstract string IdeaFormatted { get; }

        protected abstract void RunCore();

        public void Run()
        {
            Console.WriteLine("/------------------------------------------------\\");

            ConsoleOutputIntroduction();

            Console.WriteLine(IdeaFormatted);

            RunCore();

            Console.WriteLine("\\------------------------------------------------/\n");
        }

        private void ConsoleOutputIntroduction()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"\t[{Name}]");
            Console.WriteLine(DescriptionFormatted);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
