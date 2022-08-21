using System;
using DevGuru.Core.AbstractFactory.Interfaces;

namespace DevGuru.Core.AbstractFactory.Mac
{
    public class MacButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("MacButton clicked");
        }

        public void Draw()
        {
            Console.WriteLine("MacButton is drawn");
        }
    }
}
