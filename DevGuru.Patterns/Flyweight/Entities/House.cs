using System;

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

            Console.WriteLine($"The {nameof(House)} with [{Layout.Type}] {nameof(HouseLayout)} is created; ({Layout.Size} Mb)");
        }

        public void Draw()
        {
            Layout.Draw(x, y);
        }
    }
}
