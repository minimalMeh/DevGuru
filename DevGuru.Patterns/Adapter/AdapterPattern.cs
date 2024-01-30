using DevGuru.Core;
using DevGuru.Patterns.Adapter;

namespace DevGuru.Patterns
{
    public class AdapterPattern : PatternBase
    {
        public override string Name => "Adapter";
        protected override string DescriptionFormatted => "\t[Allows the interface of an existing class to be used as another interface,]\n\t[facilitating the collaboration between incompatible interfaces.]\n";
        protected override string IdeaFormatted => "\t[Modern Diagnosis service that prints doctor's report]\n\t[but has a dependency on the legacy XRay service]\n";

        protected override void RunCore()
        {
            IDiagnosisService adapter = new DiagnosisService(new LegacyXRayService("HighSpeedXRay"));
            adapter.PrintReport();
        }
    }
}
