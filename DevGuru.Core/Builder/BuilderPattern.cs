using DevGuru.Core.Builder;
using System;

namespace DevGuru.Patterns.Builder
{
    public class BuilderPattern : BasePattern
    {
        public override string Name => "Builder";

        public override string IdeaFormatted => "\t[Bakery can produce different products.]\n\t[Specify the concrete product ingredients builder.]\n";

        public override void RunCore()
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
