using DevGuru.Core.FactoryMethod.Interfaces;
using System;

namespace DevGuru.Core.FactoryMethod.Buttons
{
    public class WindowsButton : IOkButton
    {
        public void OnClick(Action callback)
        {
            Console.WriteLine("Windows button clicked.");
            callback();
        }

        public void Render()
        {
            Console.WriteLine("Windows button rendered.");
        }
    }
}
