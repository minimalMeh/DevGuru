using System;
using DevGuru.Core.AbstractFactory.Interfaces;

namespace DevGuru.Core.AbstractFactory.Windows
{
    public class WinButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("WinButton clicked");
        }

        public void Draw()
        {
            Console.WriteLine("WinButton is drawn");
        }
    }
}
