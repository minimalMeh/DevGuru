using System;
using System.Collections.Generic;
using System.Text;

namespace DevGuru.Core.Visitor
{
    public class Circle : Dot
    {
        public int Radius { get; private set; }

        public Circle(int id, int radius, int x = 0, int y = 0) : base(id, x, y)
        {
            Radius = radius;
        }

        public override string Accept(IVisitor visitor)
        {
            return visitor.VisitCircle(this);
        }

        public new void Draw()
        {
            Console.WriteLine($"{Id}: [{X};{Y}]\n\t({Radius})");
        }
    }
}
