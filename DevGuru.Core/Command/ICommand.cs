﻿namespace DevGuru.Core.Command
{
    public interface ICommand
    {
        void Execute();

        void Undo();
    }
}
