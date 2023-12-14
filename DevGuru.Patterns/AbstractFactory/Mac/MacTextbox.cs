using DevGuru.Patterns.AbstractFactory.Interfaces;
using System;

namespace DevGuru.Patterns.AbstractFactory.Mac
{
    public class MacTextbox : ITextbox
    {
        public void Draw()
        {
            Console.WriteLine($"{nameof(MacTextbox)} is drawn");
        }
    }
}
