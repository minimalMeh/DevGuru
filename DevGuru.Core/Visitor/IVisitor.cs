using System;
using System.Collections.Generic;
using System.Text;

namespace DevGuru.Core.Visitor
{
    public interface IVisitor
    {
        string VisitDot(Dot dot);
        string VisitCircle(Circle circle);
    }
}
