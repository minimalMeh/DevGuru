using DevGuru.Core.AbstractFactory.Interfaces;

namespace DevGuru.Core.AbstractFactory.Windows
{
    public class WinFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }

        public ITextbox CreateTextbox()
        {
            return new WinTextbox();
        }
    }
}
