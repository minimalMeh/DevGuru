using System;
using System.Collections.Generic;
using System.Text;

namespace DevGuru.Core.Visitor
{
    public interface IShape
    {
        void Move(int x, int y);
        void Draw();
        string Accept(IVisitor visitor);
    }
}
