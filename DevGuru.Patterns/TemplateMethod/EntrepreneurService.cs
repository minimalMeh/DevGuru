using System;
using System.IO;

namespace DevGuru.Patterns.TemplateMethod
{
    public abstract class EntrepreneurService
    {
        protected abstract bool IsDocumentsPackValid();
        protected abstract void SavePassport(FileInfo passport);
        protected abstract void SaveInn(FileInfo inn);
        protected virtual void SaveESign(FileInfo eSign) { }

        public void SaveDocuments(FileInfo passport, FileInfo inn, FileInfo eSign = null)
        {
            SavePassport(passport);
            SaveInn(inn);
            SaveESign(eSign);
        }

        public void SendDocumentsValidationRequest()
        {
            if (IsDocumentsPackValid())
            {
                Console.WriteLine("Documents were sent to the registry for validation...");
            }
            else
            {
                Console.WriteLine("ERROR! Documents are invalid. Can't send the validation request.");
            }
        }
    }
}
