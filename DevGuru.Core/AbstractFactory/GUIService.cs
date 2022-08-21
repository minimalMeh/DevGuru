using System;
using DevGuru.Core.AbstractFactory.Interfaces;
using DevGuru.Core.AbstractFactory.Mac;
using DevGuru.Core.AbstractFactory.Windows;

namespace DevGuru.Core.AbstractFactory
{
    public static class GUIService
    {
        public static void SimulateGUI(string configuration)
        {
            IGUIFactory factory;

            if (configuration.Equals("Windows", StringComparison.OrdinalIgnoreCase))
            {
                factory = new WinFactory();
            }
            else if (configuration.Equals("Mac", StringComparison.OrdinalIgnoreCase))
            {
                factory = new MacFactory();
            }
            else
            {
                Console.WriteLine("Invalid configuration. please specify windows or mac");
                return;
            }

            var btn = factory.CreateButton();
            var txtBox = factory.CreateTextbox();

            btn.Draw();
            btn.Click();
            txtBox.Draw();
        }
    }
}
