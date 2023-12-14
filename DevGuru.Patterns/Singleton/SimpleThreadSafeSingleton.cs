namespace DevGuru.Patterns.Singleton
{
    public sealed class SimpleThreadSafeSingleton
    {
        private static SimpleThreadSafeSingleton instance = null;
        private static readonly object padlock = new object();

        private SimpleThreadSafeSingleton()
        {
            System.Console.WriteLine("TOP 2: SimpleThreadSafeSingleton Created.");
        }

        public static SimpleThreadSafeSingleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SimpleThreadSafeSingleton();
                    }

                    return instance;
                }
            }
        }
    }
}
