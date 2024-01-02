namespace DevGuru.Patterns.Memento
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
            System.Console.WriteLine($"Executed {nameof(MovePointerCommand)}: (X: {curX}, Y: {curY}).");
        }

        public override string ToString()
        {
            return $"{nameof(MovePointerCommand)} set the coordinates to (X: {curX}, Y: {curY}).";
        }
    }
}
