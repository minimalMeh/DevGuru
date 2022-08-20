using System;
using System.IO;

namespace DevGuru.Core.TemplateMethod
{
    public class DiyaEntrepreneurService : EntrepreneurService
    {
        private FileInfo passport;
        private FileInfo inn;
        private FileInfo eSign;

        protected override bool IsDocumentsPackValid()
        {
            return passport != null && inn != null && eSign != null;
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
                Console.WriteLine("Saved INN via Diya");
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
            else if (!Path.GetDirectoryName(passport.FullName).Contains("diya", StringComparison.OrdinalIgnoreCase)) // Some dummy validation specific for Diya
            {
                //throw new InvalidOperationException("Passport should be stored in folder 'diya'");
                Console.WriteLine("InvalidOperationException with 'Passport should be stored in folder 'diya'' message.");
            }
            else
            {
                this.passport = passport;
                Console.WriteLine("Saved passport via Diya");
            }
        }

        protected override void SaveESign(FileInfo eSign)
        {
            if (eSign == null)
            {
                //throw new NullReferenceException("INN is required");
                Console.WriteLine("NullReferenceException with 'INN is required' message.");
            }
            else if (!eSign.Name.Contains("key", StringComparison.OrdinalIgnoreCase) || eSign.Extension != ".dat")
            {
                //throw new InvalidOperationException("ESign file should be named 'key.dat'");
                Console.WriteLine("InvalidOperationException with 'ESign file should be named 'key.dat'' message.");
            }
            else if (!Path.GetDirectoryName(passport.FullName).Contains("diya", StringComparison.OrdinalIgnoreCase)) // Some dummy validation specific for Diya
            {
                //throw new InvalidOperationException("INN should be stored in folder 'diya'");
                Console.WriteLine("InvalidOperationException with 'INN should be stored in folder 'diya'' message.");
            }
            else
            {
                this.eSign = eSign;
                Console.WriteLine("Saved eSign via Diya");
            }
        }
    }
}
