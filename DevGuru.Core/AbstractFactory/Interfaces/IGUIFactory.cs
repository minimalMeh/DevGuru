namespace DevGuru.Core.AbstractFactory.Interfaces
{
    public interface IGUIFactory
    {
        IButton CreateButton();
        ITextbox CreateTextbox();
    }
}
