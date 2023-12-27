using System;
using System.IO;
using System.Reflection;

namespace DevGuru.Patterns.Flyweight.Entities
{
    public class HouseLayout
    {
        private readonly Bitmap bitmap;

        public string Type { get; }
        public int Size => bitmap?.Size ?? 0;

        public HouseLayout(string type)
        {
            Type = type;
            bitmap = new Bitmap(Path.Combine(Assembly.GetExecutingAssembly().Location, Type));
        }

        public void Draw(int x, int y)
        {
            // Drawing using coordinates, bitmap and type
            Console.WriteLine($"The {nameof(HouseLayout)} {Type} is drawn by coordinates [{x};{y}]");
        }
    }
}
