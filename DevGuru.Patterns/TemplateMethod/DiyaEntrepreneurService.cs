using System;
using System.IO;

namespace DevGuru.Patterns.TemplateMethod
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
            this.inn = inn;
            Console.WriteLine("DIYA: INN saved.");
        }

        protected override void SavePassport(FileInfo passport)
        {
            this.passport = passport;
            Console.WriteLine("DIYA: Passport saved.");
        }

        protected override void SaveESign(FileInfo eSign)
        {
            this.eSign = eSign;
            Console.WriteLine("DIYA: eSign saved.");
        }
    }
}
