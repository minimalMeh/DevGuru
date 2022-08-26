namespace DevGuru.Core.Command
{
    // Invoker
    public class TVRemote
    {
        ICommand command;

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
