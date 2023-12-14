using System;

namespace DevGuru.Patterns.Adapter
{
    public class DiagnosisService : IDiagnosisService
    {
        private readonly LegacyXRayService legacyXRayService;

        public DiagnosisService(LegacyXRayService legacyXRayService)
        {
            this.legacyXRayService = legacyXRayService;
        }

        public void PrintReport()
        {
            Console.WriteLine($"{nameof(DiagnosisService)} is executing {nameof(PrintReport)}");

            Console.WriteLine("\tReport:");
            Console.WriteLine("\tDoctors report: " + GetDoctorsConclusion());
            Console.WriteLine("\tX-ray information:" + "\n\t\t" + legacyXRayService.Analyze());
        }

        private static string GetDoctorsConclusion()
        {
            return $"{nameof(GetDoctorsConclusion)} is called. Some Doctor's conclusion.";
        }
    }
}
