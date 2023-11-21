using DevGuru.Core.Adapter;

namespace DevGuru.Patterns.Adapter
{
    public class AdapterPattern : IPattern
    {
        public void Run()
        {
            IDiagnosisService adapter = new DiagnosisService(new LegacyXRayService("HighSpeedXRay"));
            adapter.PrintReport();
        }
    }
}
