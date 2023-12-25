using DevGuru.Core;
using System;

namespace DevGuru.Patterns.FactoryMethod
{
    public class FactoryMethodPattern : BasePattern
    {
        public override string Name => "Factory Method";
        protected override string DescriptionFormatted => "\t[Defines an interface for creating an object but allows subclasses to alter the type of objects]\n\t[that will be created, encapsulating the object creation logic.]\n";
        protected override string IdeaFormatted => "[A service is responsible for the UI elements rendering. It coulde be either WebView or Windows UI elements.]\t\n[A dialog element contains a button.]";

        protected override void RunCore()
        {
            Console.Write("Win/Web: ");
            var config = Console.ReadLine().ToLowerInvariant();
            if (config == "q") return;

            var dialogService = new DialogService();
            dialogService.Initialize(config);
            dialogService.Render();
        }
    }
}
