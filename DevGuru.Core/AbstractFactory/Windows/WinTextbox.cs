using System;
using System.Collections.Generic;
using System.Text;
using DevGuru.Core.AbstractFactory.Interfaces;

namespace DevGuru.Core.AbstractFactory.Windows
{
    public class WinTextbox : ITextbox
    {
        public void Draw()
        {
            Console.WriteLine("Draw Win textbox");
        }
    }
}
