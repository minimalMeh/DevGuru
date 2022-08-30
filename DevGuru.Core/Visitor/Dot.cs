using System;

namespace DevGuru.Core.Visitor
{
    public class Dot : IShape
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Id { get; private set; }

        public Dot(int id, int x = 0, int y = 0)
        {
            Id = id;
            X = x;
            Y = y;
        }

        public virtual string Accept(IVisitor visitor)
        {
            return visitor.VisitDot(this);
        }

        public void Draw()
        {
            Console.WriteLine($"{Id}: [{X};{Y}]\n\t\t.");
        }

        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
