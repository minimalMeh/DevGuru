namespace DevGuru.Patterns.Singleton
{
    // Fourth version - not quite as lazy, but thread-safe without using locks
    public sealed class NotLazyButThreadSafeWithoutLocksSingleton
    {
        private static readonly NotLazyButThreadSafeWithoutLocksSingleton instance = new NotLazyButThreadSafeWithoutLocksSingleton();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static NotLazyButThreadSafeWithoutLocksSingleton()
        {
        }

        private NotLazyButThreadSafeWithoutLocksSingleton()
        {
            System.Console.WriteLine("TOP 1: NotLazyButThreadSafeWithoutLocksSingleton Created.");
        }

        public static NotLazyButThreadSafeWithoutLocksSingleton Instance => instance;

        public override string ToString()
        {
            return @"Well, static constructors in C# are specified to execute only when an instance 
of the class is created or a static member is referenced, and to execute only once per AppDomain. ";
        }
    }
}
