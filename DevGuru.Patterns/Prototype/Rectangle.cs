namespace DevGuru.Patterns.Prototype
{
    public class Rectangle : Shape
    {
        protected int width;
        protected int height;
        public string rectangleName;

        public Rectangle(int x, int y, int width, int height) : base(x, y)
        {
            this.width = width;
            this.height = height;
            rectangleName = "Rect#" + info.Id;
        }

        public Rectangle(Rectangle prototype) : base(prototype)
        {
            this.width = prototype.width;
            this.height = prototype.height;
            rectangleName = "Rect#" + info.Id;
            rectangleName = new string(prototype.rectangleName);
        }

        public override Shape Clone()
        {
            return new Rectangle(this);
        }

        public override string ToString()
        {
            return $"\t{rectangleName} [{x};{y}],\n\twidth: {width}, height: {height},\n\tDate created: {dateCreated:MM/dd/ yyyy hh:mm ss.ffffffK}\n";
        }
    }
}
