using DevGuru.Core;
using System;

namespace DevGuru.Patterns.AbstractFactory
{
    public class AbstractFactoryPattern : PatternBase
    {
        public override string Name => "Abstract Factory";
        protected override string DescriptionFormatted => "\t[Provides an interface for creating families of related or dependent objects]\n\t[without specifying their concrete classes, promoting flexibility in object creation.]\n";
        protected override string IdeaFormatted => "\t[You have to render GUI elements]\n\t[on different OS. Specify OS [Win] or [Mac]\n";

        protected override void RunCore()
        {
            Console.Write("Mac/Win: ");
            var result = Console.ReadLine().ToLowerInvariant();
            if (result == "q") return;

            GUIService.SimulateGUI(result);
        }
    }
}
