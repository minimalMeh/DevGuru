using System;

namespace DevGuru.Patterns.Flyweight.Entities
{
    // Represents a class that has some memory-consuming information like bitmap image bytes.
    public class Bitmap
    {
        public string FileName { get; }

        public int Size { get; }

        public Bitmap(string fileName)
        {
            FileName = fileName;
            Size = new Random().Next(1000, 9000);
        }
    }
}
