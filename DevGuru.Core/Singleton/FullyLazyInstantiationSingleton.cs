namespace DevGuru.Core.Singleton
{
    public sealed class FullyLazyInstantiationSingleton
    {
        private FullyLazyInstantiationSingleton()
        {
            System.Console.WriteLine("TOP 4: FullyLazyInstantiationSingleton Created.");
        }

        // Instantiation is triggered by the first referenceto the static member
        // of the nested class, which only occurs in Instance.
        public static FullyLazyInstantiationSingleton Instance => Nested.instance;

        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit. Thread-safe
            static Nested()
            {

            }

            internal static readonly FullyLazyInstantiationSingleton instance = new FullyLazyInstantiationSingleton();
        }
    }
}
