using System;
using System.Collections.Generic;
using System.Text;

namespace DevGuru.Core.Visitor
{
    public class XmlExportVisitor : IVisitor
    {
        public string Export(params IShape[] shapes)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>" + "\n");

            foreach (var shape in shapes)
            {
                sb.Append(shape.Accept(this)).Append("\n");
            }

            return sb.ToString();
        }

        public string VisitCircle(Circle circle)
        {
            return "<circle>" + "\n" +
        "    <id>" + circle.Id + "</id>" + "\n" +
        "    <x>" + circle.X + "</x>" + "\n" +
        "    <y>" + circle.Y + "</y>" + "\n" +
        "    <radius>" + circle.Radius + "</radius>" + "\n" +
        "</circle>";
        }

        public string VisitDot(Dot dot)
        {
            return "<dot>" + "\n" +
        "    <id>" + dot.Id + "</id>" + "\n" +
        "    <x>" + dot.X + "</x>" + "\n" +
        "    <y>" + dot.Y + "</y>" + "\n" +
        "</dot>";
        }
    }
}
