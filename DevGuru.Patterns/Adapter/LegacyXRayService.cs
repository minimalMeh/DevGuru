using System;

namespace DevGuru.Patterns.Adapter
{
    // Adaptee with useful beahvior.
    public sealed class LegacyXRayService
    {
        private readonly string configuration;

        public LegacyXRayService(string configuration)
        {
            this.configuration = configuration;
        }

        public string Analyze()
        {
            Console.WriteLine($"{nameof(LegacyXRayService)} is executing {nameof(Analyze)}");
            return $"Some conclusion after the analysis in the {nameof(LegacyXRayService)}. Configuration: {configuration}";
        }
    }
}
