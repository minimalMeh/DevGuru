using System;
using System.IO;

namespace DevGuru.Core.TemplateMethod
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
            if (inn == null)
            {
                //throw new NullReferenceException("INN is required");
                Console.WriteLine("NullReferenceException with 'INN is required' message.");
            }
            else if (!inn.Name.Contains("inn", StringComparison.OrdinalIgnoreCase))
            {
                //throw new InvalidOperationException("INN file should have name 'inn'");
                Console.WriteLine("InvalidOperationException with 'INN file should have name 'inn'' message.");
            }
            else
            {
                this.inn = inn;
                Console.WriteLine("Saved inn via Notary");
            }
        }

        protected override void SavePassport(FileInfo passport)
        {
            if (passport == null)
            {
                //throw new NullReferenceException("Passport is required");
                Console.WriteLine("NullReferenceException with 'Passport is required' message.");
            }
            else if (!passport.Name.Contains("passport", StringComparison.OrdinalIgnoreCase))
            {
                //throw new InvalidOperationException("Passport file should have name 'passport'");
                Console.WriteLine("InvalidOperationException with 'Passport file should have name 'passport'' message.");
            }
            else
            {
                this.passport = passport;
                Console.WriteLine("Saved passport via Notary");
            }
        }
    }
}
