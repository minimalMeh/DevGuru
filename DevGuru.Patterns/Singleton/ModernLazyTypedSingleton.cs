using System;

namespace DevGuru.Patterns.Singleton
{
    public sealed class ModernLazyTypedSingleton
    {
        // The code implicitly uses
        // LazyThreadSafetyMode.ExecutionAndPublication as the thread safety mode
        // for the Lazy<Singleton>. 
        private static readonly Lazy<ModernLazyTypedSingleton> lazy = new(() => new ModernLazyTypedSingleton());
        public static ModernLazyTypedSingleton Instance => lazy.Value;

        private ModernLazyTypedSingleton()
        {
            Console.WriteLine("TOP 3: ModernLazyTypedSingleton.");
        }
    }
}
