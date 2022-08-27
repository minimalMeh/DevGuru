namespace DevGuru.Core.Memento
{
    public class ChangeTextCommand : ICommand
    {
        private readonly Editor editor;
        private readonly string text;

        public ChangeTextCommand(Editor editor, string text)
        {
            this.editor = editor;
            this.text = text;
        }

        public void Execute()
        {
            editor.SetText(text);
            System.Console.WriteLine($"Executed {this}");
        }

        public override string ToString()
        {
            return $"{GetType().Name} to text \"{text}\"";
        }
    }
}
