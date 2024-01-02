using System;
using System.Collections.Generic;

namespace DevGuru.Patterns.Memento
{
    public class History // Caretaker
    {
        private readonly List<(ICommand, Snapshot)> history = new();
        private int virtualPointer;

        public void Push(ICommand command, Snapshot snapshot)
        {
            if (virtualPointer > 0 && virtualPointer != history.Count)
            {
                history.RemoveRange(virtualPointer, history.Count - virtualPointer);
            }

            history.Add((command, snapshot));
            virtualPointer = history.Count;
        }

        public bool Undo()
        {
            if (virtualPointer == 0)
            {
                Console.WriteLine("Can't move back, the history is empty.");
                return false;
            }

            var item = history[virtualPointer - 1];
            history[virtualPointer - 1].Item2.Restore();
            virtualPointer--;

            Console.WriteLine($"Moved back. Undo [{item.Item1}, date performed {item.Item2.GetSnapshotDate()}]");
            return true;
        }

        public bool Redo()
        {
            if (virtualPointer < history.Count)
            {
                var item = history[virtualPointer];

                history[virtualPointer].Item2.Restore();
                virtualPointer++;
                Console.WriteLine($"Moved forward. Redo [{item.Item1}, date performed {item.Item2.GetSnapshotDate()}]");
                return true;
            }

            Console.WriteLine("Can't move forward, no following actions.");
            return false;
        }
    }
}
