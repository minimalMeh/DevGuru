using DevGuru.Patterns.FactoryMethod.Buttons;
using DevGuru.Patterns.FactoryMethod.Interfaces;

namespace DevGuru.Patterns.FactoryMethod.Dialogs
{
    public class WebViewDialog : Dialog
    {
        protected override IOkButton CreateButton() => new WebViewButton();
    }
}
