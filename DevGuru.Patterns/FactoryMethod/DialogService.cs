using DevGuru.Patterns.FactoryMethod.Dialogs;
using System;

namespace DevGuru.Patterns.FactoryMethod
{
    public class DialogService
    {
        private Dialog dialog;

        public void Initialize(string configuration)
        {
            if (configuration.Equals("Win", StringComparison.OrdinalIgnoreCase))
            {
                dialog = new WindowsDialog();
            }
            else if (configuration.Equals("Web", StringComparison.OrdinalIgnoreCase))
            {
                dialog = new WebViewDialog();
            }
            else
            {
                Console.WriteLine("Invalid configuration. Please specify Win or Web.");
            }
        }

        public void Render()
        {
            dialog?.Render();
        }
    }
}
