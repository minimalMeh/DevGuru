using System;

namespace DevGuru.Patterns.Singleton
{
    public sealed class FullyLazyInstantiationSingleton
    {
        // Instantiation is triggered by the first referenceto the static member
        // of the nested class, which only occurs in Instance.
        public static FullyLazyInstantiationSingleton Instance => Nested.instance;

        private FullyLazyInstantiationSingleton()
        {
            Console.WriteLine("TOP 4: FullyLazyInstantiationSingleton.");
        }

        private class Nested
        {
            internal static readonly FullyLazyInstantiationSingleton instance = new();

            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit. Thread-safe
            static Nested() { }
        }
    }
}
