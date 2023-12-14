using DevGuru.Patterns.FactoryMethod.Interfaces;
using System;

namespace DevGuru.Patterns.FactoryMethod.Buttons
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
