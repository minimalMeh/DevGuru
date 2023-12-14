namespace DevGuru.Patterns.Visitor
{
    public interface IShape
    {
        void Move(int x, int y);
        void Draw();
        string Accept(IVisitor visitor);
    }
}
