using DevGuru.Core.FactoryMethod.Buttons;
using DevGuru.Core.FactoryMethod.Interfaces;

namespace DevGuru.Core.FactoryMethod.Dialogs
{
    public class WebViewDialog : Dialog
    {
        protected override IOkButton CreateButton()
        {
            return new WebViewButton();
        }
    }
}
