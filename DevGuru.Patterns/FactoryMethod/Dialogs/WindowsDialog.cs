using DevGuru.Patterns.FactoryMethod.Buttons;
using DevGuru.Patterns.FactoryMethod.Interfaces;

namespace DevGuru.Patterns.FactoryMethod.Dialogs
{
    public class WindowsDialog : Dialog
    {
        protected override IOkButton CreateButton()
        {
            return new WindowsButton();
        }
    }
}
