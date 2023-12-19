namespace DevGuru.Patterns.Command
{
    // Invoker
    public class TVRemote
    {
        readonly ICommand command;

        public TVRemote(ICommand command)
        {
            this.command = command;
        }

        public void TurnOnTV()
        {
            command.Execute();
        }

        public void TurnOffTV()
        {
            command.Undo();
        }
    }
}
