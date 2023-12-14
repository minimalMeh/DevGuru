using DevGuru.Patterns;
using System;

namespace DevGuru.Core.AbstractFactory
{
    public class AbstractFactoryPattern : BasePattern
    {
        public override string Name => "Abstract Factory";
        public override string IdeaFormatted => "\t[You have to render GUI elements]\n\t[on different OS. Specify OS [Win] or [Mac]\n";

        public override void RunCore()
        {
            Console.Write("Mac/Win: ");
            var result = Console.ReadLine().ToLowerInvariant();
            if (result == "q") return;

            GUIService.SimulateGUI(result);
        }
    }
}
