using System;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace DevGuru.Patterns.Flyweight.Entities
{
    public class HouseLayout
    {
        private readonly Bitmap bitmap;

        public string Type { get; }

        public HouseLayout(string type, string bitmapName = null)
        {
            Type = type;

            try
            {
#pragma warning disable CA1416 // Validate platform compatibility
                bitmap = new Bitmap(Path.Combine(Assembly.GetExecutingAssembly().Location, "layouts", Type, bitmapName));
#pragma warning restore CA1416 // Validate platform compatibility
            }
            catch
            {
                // Console.WriteLine("An exception has occured when tryied to get the bitmap");
            }

            Console.WriteLine($"* The {nameof(HouseLayout)} created with type {Type};");
        }

        public void Draw(int x, int y)
        {
            // Drawing using coordinates, bitmap and type
            Console.WriteLine($"The {nameof(HouseLayout)} {Type} drawed on coordinates [{x};{y}]");
        }
    }
}
