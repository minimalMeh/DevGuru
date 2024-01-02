using DevGuru.Core;
using System;

namespace DevGuru.Patterns.Memento
{
    public class MementoPattern : BasePattern
    {
        public override string Name => "Memento";
        protected override string DescriptionFormatted => "\t[Captures and externalizes an object's internal state so that the object]\n\t[can be restored to this state later, without exposing its internal structure.]\n";
        protected override string IdeaFormatted => "\t[UI editor can move mouse pointer or change the text. To save the history of actions,]\n\t[the Editor stores a History object which contains a list of actions.]\n";

        protected override void RunCore()
        {
            var editor = new Editor();

            editor.Execute(new ChangeTextCommand(editor, "Welcome!"));
            editor.Execute(new ChangeTextCommand(editor, "Log in!"));
            editor.Execute(new MovePointerCommand(editor, 100, 100));

            Console.WriteLine();

            editor.History.Undo();
            editor.History.Undo();
            editor.History.Redo();

            Console.WriteLine();

            editor.Execute(new ChangeTextCommand(editor, "Try again?"));
            editor.Execute(new MovePointerCommand(editor, 200, 250));

            Console.WriteLine();

            editor.History.Redo();
            editor.History.Undo();
            editor.History.Undo();
            editor.History.Undo();
            editor.History.Undo();
            editor.History.Undo();
        }
    }
}
