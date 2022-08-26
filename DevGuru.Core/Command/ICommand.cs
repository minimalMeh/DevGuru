using System;
using System.Collections.Generic;
using System.Text;

namespace DevGuru.Core.Command
{
    public interface ICommand
    {
        void Execute();

        void Undo();
    }
}
