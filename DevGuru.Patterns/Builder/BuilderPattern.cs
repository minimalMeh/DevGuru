using DevGuru.Core;
using System;

namespace DevGuru.Patterns.Builder
{
    public class BuilderPattern : PatternBase
    {
        public override string Name => "Builder";
        protected override string DescriptionFormatted => "\t[Separates the construction of a complex object from its representation,]\n\t[allowing the same construction process to create different representations.]\n";
        protected override string IdeaFormatted => "\t[Bakery can produce different products.]\n\t[Specify the concrete product ingredients builder.]\n";

        protected override void RunCore()
        {
            var cBuilder = new CroissantBuilder();
            Bakery.Bake(cBuilder);
            Console.WriteLine(cBuilder.GetProduct());

            var bBuilder = new BaguetteBuilder();
            Bakery.Bake(bBuilder);
            Console.WriteLine(bBuilder.GetProduct());
        }
    }
}
