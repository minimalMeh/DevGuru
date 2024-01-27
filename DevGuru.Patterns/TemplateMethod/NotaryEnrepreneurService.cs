using System;
using System.IO;

namespace DevGuru.Patterns.TemplateMethod
{
    public class NotaryEnrepreneurService : EntrepreneurService
    {
        private FileInfo passport;
        private FileInfo inn;

        protected override bool IsDocumentsPackValid()
        {
            return passport != null && inn != null;
        }

        protected override void SaveInn(FileInfo inn)
        {
            this.inn = inn;
            Console.WriteLine("Notary: Inn saved.");
        }

        protected override void SavePassport(FileInfo passport)
        {
            this.passport = passport;
            Console.WriteLine("Notary: Passport saved.");
        }
    }
}
