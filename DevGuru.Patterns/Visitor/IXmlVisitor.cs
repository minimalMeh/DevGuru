namespace DevGuru.Patterns.Visitor
{
    public interface IXmlVisitor
    {
        string VisitDot(Dot dot);
        string VisitCircle(Circle circle);
    }
}
