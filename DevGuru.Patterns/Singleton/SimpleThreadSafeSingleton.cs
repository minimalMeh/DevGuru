using System;

namespace DevGuru.Patterns.Singleton
{
    public sealed class SimpleThreadSafeSingleton
    {
        private static SimpleThreadSafeSingleton instance = null;
        private static readonly object padlock = new();

        private SimpleThreadSafeSingleton()
        {
            Console.WriteLine("TOP 2: SimpleThreadSafeSingleton.");
        }

        public static SimpleThreadSafeSingleton Instance
        {
            get
            {
                lock (padlock)
                {
                    return instance ??= new SimpleThreadSafeSingleton();
                }
            }
        }
    }
}
