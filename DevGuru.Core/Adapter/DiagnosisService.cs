using System;

namespace DevGuru.Core.Adapter
{
    public class DiagnosisService : IDiagnosisService
    {
        private readonly LegacyXRayService legacyXRayService;
        public DiagnosisService(LegacyXRayService legacyXRayService)
        {
            this.legacyXRayService = legacyXRayService;
        }

        public void Print()
        {
            Console.WriteLine("\tReport:");
            Console.WriteLine("\tDoctors report: " + GetDoctorsConclusion());
            Console.WriteLine("\tX-ray information:" + "\n\t\t" + legacyXRayService.Analyze());
        }

        private string GetDoctorsConclusion()
        {
            return "\n\t\tBlah blah hope you don't die soon.";
        }
    }
}
