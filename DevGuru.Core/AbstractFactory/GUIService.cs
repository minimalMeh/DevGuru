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
