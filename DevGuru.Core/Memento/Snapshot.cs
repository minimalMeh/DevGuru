using System;

namespace DevGuru.Core.Memento
{
    public class Snapshot // Memento
    {
        private readonly Editor editor;
        private readonly string text;
        private readonly int curX, curY;
        private readonly DateTime snapshotDate;

        public Snapshot(Editor editor, string text, int x, int y)
        {
            this.editor = editor;
            this.text = text;
            curX = x;
            curY = y;
            snapshotDate = DateTime.Now;
        }

        public DateTime GetSnapshotDate() => snapshotDate;

        public void Restore()
        {
            editor.SetText(text);
            editor.SetCursor(curX, curY);
        }
    }
}
