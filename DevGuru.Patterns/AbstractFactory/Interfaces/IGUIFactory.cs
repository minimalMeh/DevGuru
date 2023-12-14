namespace DevGuru.Patterns.AbstractFactory.Interfaces
{
    public interface IGUIFactory
    {
        IButton CreateButton();
        ITextbox CreateTextbox();
    }
}
