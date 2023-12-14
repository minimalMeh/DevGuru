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

        public void SendRequest()
        {
            if (IsDocumentsPackValid())
            {
                SendDocumentsToRegistry();
            }
            else
            {
                Console.WriteLine("Documents are invalid to send request");
            }
        }

        private void SendDocumentsToRegistry()
        {
            Console.WriteLine("The documents are sent to the registry for validation.");
        }
    }
}
