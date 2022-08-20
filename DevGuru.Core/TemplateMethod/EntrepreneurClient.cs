using System.IO;

namespace DevGuru.Core.TemplateMethod
{
    public class EntrepreneurClient
    {
        public static void SendRequestToBeEntrepreneur(EntrepreneurService service, FileInfo passport, FileInfo inn, FileInfo eSign = null)
        {
            service.SaveDocuments(passport, inn, eSign);
            service.SendRequest();
        }
    }
}
