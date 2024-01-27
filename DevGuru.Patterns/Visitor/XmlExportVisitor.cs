using System.Text;

namespace DevGuru.Patterns.Visitor
{
    public class XmlExportVisitor : IXmlVisitor
    {
        public string Export(params IShape[] shapes)
        {
            StringBuilder sb = new();
            sb.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            sb.Append('\n');

            foreach (var shape in shapes)
            {
                string shapeXml = shape.XmlExport(this);
                sb.Append(shapeXml).Append('\n');
            }

            sb.Append("</xml>");
            return sb.ToString();
        }

        public string VisitCircle(Circle circle) =>
        "<circle>" + "\n" +
        "    <id>" + circle.Id + "</id>" + "\n" +
        "    <x>" + circle.X + "</x>" + "\n" +
        "    <y>" + circle.Y + "</y>" + "\n" +
        "    <radius>" + circle.Radius + "</radius>" + "\n" +
        "</circle>";

        public string VisitDot(Dot dot) =>
        "<dot>" + "\n" +
        "    <id>" + dot.Id + "</id>" + "\n" +
        "    <x>" + dot.X + "</x>" + "\n" +
        "    <y>" + dot.Y + "</y>" + "\n" +
        "</dot>";
    }
}
