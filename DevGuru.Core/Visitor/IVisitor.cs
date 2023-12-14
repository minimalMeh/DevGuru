namespace DevGuru.Core.Visitor
{
    public interface IVisitor
    {
        string VisitDot(Dot dot);
        string VisitCircle(Circle circle);
    }
}
