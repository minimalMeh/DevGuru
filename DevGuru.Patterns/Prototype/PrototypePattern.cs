using DevGuru.Core;
using System;

namespace DevGuru.Patterns.Prototype
{
    public class PrototypePattern : PatternBase
    {
        public override string Name => "Prototype";
        protected override string DescriptionFormatted => "\t[Creates new objects by copying an existing object,]\n\t[allowing for the creation of new instances without specifying their concrete classes.]\n";
        protected override string IdeaFormatted => "\t[The Prototype pattern lets you produce exact copies of the geometric rectangle object,]\n\t[without coupling the code to its class.]\n";

        protected override void RunCore()
        {
            var benchmark = new Rectangle(10, 20, 200, 300);
            Console.WriteLine(benchmark);

            Rectangle bcopy = benchmark.Clone() as Rectangle;
            Console.WriteLine(bcopy);

            Console.WriteLine($@"Check references
benchmark == bcopy: {benchmark == bcopy}
string benchmark.rectangleName == bcopy.rectangleName: {benchmark.rectangleName == bcopy.rectangleName}
ReferenceEquals benchmark.rectangleName, bcopy.rectangleName: {object.ReferenceEquals(benchmark.rectangleName, bcopy.rectangleName)}");
        }
    }
}
