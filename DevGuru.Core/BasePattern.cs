using System;

namespace DevGuru.Patterns
{
    public abstract class BasePattern : IPattern
    {
        public abstract string Name { get; }
        public abstract void RunCore();

        public void Run()
        {
            Console.WriteLine($"\n\tBegin showing {Name} pattern!\n");
            RunCore();
            Console.WriteLine($"\n\tFinish showing {Name} pattern!\n");
        }
    }
}
