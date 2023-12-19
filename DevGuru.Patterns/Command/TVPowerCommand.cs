namespace DevGuru.Patterns.Command
{
    public class TVPowerCommand : ICommand
    {
        private readonly TV receiver;

        public TVPowerCommand(TV receiver)
        {

            this.receiver = receiver;
        }

        public void Execute()
        {
            receiver.On();
        }

        public void Undo()
        {
            receiver.Off();
        }
    }
}
