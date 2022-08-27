using System;
using System.Collections.Generic;
using System.Text;

namespace DevGuru.Core.Memento
{
    public interface ICommand
    {
        void Execute();
    }
}
