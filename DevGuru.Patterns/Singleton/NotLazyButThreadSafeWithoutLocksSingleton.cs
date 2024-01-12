using System;

namespace DevGuru.Patterns.Singleton
{
    // Fourth version - not quite as lazy, but thread-safe without using locks
    public sealed class NotLazyButThreadSafeWithoutLocksSingleton
    {
        private static readonly NotLazyButThreadSafeWithoutLocksSingleton instance = new();
        public static NotLazyButThreadSafeWithoutLocksSingleton Instance => instance;

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit

        // Well, static constructors in C# are specified to execute only when an instance 
        // of the class is created or a static member is referenced, and to execute only once per AppDomain.
        static NotLazyButThreadSafeWithoutLocksSingleton() { }

        private NotLazyButThreadSafeWithoutLocksSingleton()
        {
            Console.WriteLine("TOP 1: NotLazyButThreadSafeWithoutLocksSingleton.");
        }
    }
}
