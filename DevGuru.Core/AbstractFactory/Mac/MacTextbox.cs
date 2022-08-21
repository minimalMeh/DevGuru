using System;
using DevGuru.Core.AbstractFactory.Interfaces;

namespace DevGuru.Core.AbstractFactory.Mac
{
    public class MacTextbox : ITextbox
    {
        public void Draw()
        {
            Console.WriteLine("Draw Mac textbox");    
        }
    }
}
