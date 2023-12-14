using DevGuru.Core.FactoryMethod.Dialogs;
using System;

namespace DevGuru.Core.FactoryMethod
{
    public class DialogService
    {
        private Dialog dialog;

        public void Initialize(string configuration)
        {
            if (configuration.Equals("Windows", StringComparison.OrdinalIgnoreCase))
            {
                dialog = new WindowsDialog();
            }
            else if (configuration.Equals("Web", StringComparison.OrdinalIgnoreCase))
            {
                dialog = new WebViewDialog();
            }
            else
            {
                Console.WriteLine("Invalid configuration. please specify windows or mac");
                return;
            }
        }

        public void Render()
        {
            dialog.Render();
        }
    }
}
