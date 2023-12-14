namespace DevGuru.Patterns.Visitor
{
    public interface IVisitor
    {
        string VisitDot(Dot dot);
        string VisitCircle(Circle circle);
    }
}
