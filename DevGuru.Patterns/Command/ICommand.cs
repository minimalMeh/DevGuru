namespace DevGuru.Patterns.Command
{
    public interface ICommand
    {
        void Execute();

        void Undo();
    }
}
