namespace DevGuru.Patterns.Adapter
{
    public class AdapterPattern : BasePattern
    {
        public override string Name => "Adapter";
        public override string IdeaFormatted => "\t[Modern Diagnosis service that prints doctor's report,]\n\t[but has a dependency on legacy XRay service]\n";

        public override void RunCore()
        {
            IDiagnosisService adapter = new DiagnosisService(new LegacyXRayService("HighSpeedXRay"));
            adapter.PrintReport();
        }
    }
}
