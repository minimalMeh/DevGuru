using System;
using System.Collections.Generic;
using System.Text;

namespace DevGuru.Core.AbstractFactory.Interfaces
{
    public interface IGUIFactory
    {
        IButton CreateButton();
        ITextbox CreateTextbox();
    }
}
