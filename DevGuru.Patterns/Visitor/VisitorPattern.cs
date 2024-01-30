using DevGuru.Core;
using DevGuru.Patterns.Visitor;
using System;

namespace DevGuru.Patterns
{
    public class VisitorPattern : PatternBase
    {
        public override string Name => "Visitor";
        protected override string DescriptionFormatted => "\t[Represents an operation to be performed on the elements of an object structure,]\n\t[allowing the definition of new operations without changing the classes of the elements on which they operate.]\n";
        protected override string IdeaFormatted => "\t[An XML service is required to export various geometric shapes.]\n";

        protected override void RunCore()
        {
            var dot1 = new Dot(10001, 10, 20);
            var circle = new Circle(70017, 10);
            var dot2 = new Dot(10002, 11, 21);

            var exportVisitor = new XmlExportVisitor();

            Console.WriteLine(exportVisitor.Export(dot1, circle, dot2));
        }
    }
}
