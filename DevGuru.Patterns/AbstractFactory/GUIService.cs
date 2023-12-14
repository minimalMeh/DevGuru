using DevGuru.Patterns.AbstractFactory.Interfaces;
using DevGuru.Patterns.AbstractFactory.Mac;
using DevGuru.Patterns.AbstractFactory.Windows;
using System;

namespace DevGuru.Patterns.AbstractFactory
{
    public static class GUIService
    {
        public static void SimulateGUI(string configuration)
        {
            IGUIFactory factory;

            switch (configuration)
            {
                case "mac":
                    factory = new MacFactory();
                    break;
                case "win":
                    factory = new WinFactory();
                    break;
                default:
                    Console.WriteLine("Invalid configuration. please try again and specify Win or Mac.");
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
