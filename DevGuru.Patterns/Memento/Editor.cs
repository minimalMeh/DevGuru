namespace DevGuru.Patterns.Memento
{
    public class Editor // Originator
    {
        private string text;
        private int curX, curY;
        public History History { get; private set; } = new History();

        public void SetText(string text)
        {
            this.text = text;
        }

        public void SetCursor(int x, int y)
        {
            curX = x;
            curY = y;
        }

        public void Execute(ICommand command)
        {
            History.Push(command, CreateSnapshot());
            command.Execute();
        }

        public Snapshot CreateSnapshot() => new Snapshot(this, text, curX, curY);
    }
}
