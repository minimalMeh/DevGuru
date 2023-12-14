namespace DevGuru.Core.Memento
{
    public class MovePointerCommand : ICommand
    {
        private readonly Editor editor;
        private readonly int curX, curY;

        public MovePointerCommand(Editor editor, int x, int y)
        {
            this.editor = editor;
            curX = x;
            curY = y;
        }

        public void Execute()
        {
            editor.SetCursor(curX, curY);
            System.Console.WriteLine($"Executed {this}");
        }

        public override string ToString()
        {
            return $"{GetType().Name} moves X: \"{curX}\", moves Y: \"{curY}\"";
        }
    }
}
