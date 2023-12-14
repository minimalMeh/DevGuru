namespace DevGuru.Patterns.Flyweight.Entities
{
    public class House
    {
        private readonly int x;
        private readonly int y;

        public HouseLayout Layout { get; }

        public House(int x, int y, HouseLayout layout)
        {
            this.x = x;
            this.y = y;
            Layout = layout;
        }

        public void Draw()
        {
            Layout.Draw(x, y);
        }
    }
}
