using DevGuru.Patterns;
using System;

namespace DevGuru.Core.AbstractFactory
{
    public class AbstractFactoryPattern : BasePattern
    {
        public override string Name => "Abstract Factory";

        public override void RunCore()
        {
            Console.WriteLine("Imaging you have to render GUI elements\non different OS. Specify OS [Win] or [Mac]:\n");

            var result = Console.ReadLine().ToLowerInvariant();
            if (result == "q") return;

            GUIService.SimulateGUI(result);
        }
    }
}
