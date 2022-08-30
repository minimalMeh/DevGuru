using System;

namespace DevGuru.Core.Singleton
{
    public sealed class ModernLazyTypedSingleton
    {
        //The code above implicitly uses
        //LazyThreadSafetyMode.ExecutionAndPublication as the thread safety mode
        //for the Lazy<Singleton>. 
        private static readonly Lazy<ModernLazyTypedSingleton> lazy =
            new Lazy<ModernLazyTypedSingleton>(() => new ModernLazyTypedSingleton());

        public static ModernLazyTypedSingleton Instance => lazy.Value;

        private ModernLazyTypedSingleton()
        {
            System.Console.WriteLine("TOP 3: ModernLazyTypedSingleton Created.");
        }
    }
}
