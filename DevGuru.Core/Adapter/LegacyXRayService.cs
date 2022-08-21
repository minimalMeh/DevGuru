namespace DevGuru.Core.Adapter
{
    public sealed class LegacyXRayService // Adaptee with useful beahvior.
    {
        private readonly string configuration;
        public LegacyXRayService(string configuration)
        {
            this.configuration = configuration;
        }

        public string Analyze()
        {
            return "Some conclusion after the analysis. Configuration: " + configuration;
        }
    }
}
