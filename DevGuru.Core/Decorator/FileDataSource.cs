using System;
using System.IO;
using System.Text;

namespace DevGuru.Core.Decorator
{
    public class FileDataSource : IDataSource // Concrete Component
    {
        private readonly string fileName;
        private string Path => System.IO.Path.Combine(@"D:\Projects\DevGuru\DevGuru.Core\Decorator", fileName);

        public FileDataSource(string fileName)
        {
            this.fileName = fileName;
        }

        public string Read()
        {
            try
            {
                using StreamReader sr = File.OpenText(Path);
                return sr.ReadToEnd();
            }
            catch (IOException)
            {
                Console.WriteLine("An exception occured during writing to the file");
                return null;
            }
        }

        public void Write(string data)
        {
            try
            {
                Console.WriteLine($"Writing :\"{data}\" to the file.");
                using FileStream fs = File.Create(Path);
                var info = new UTF8Encoding(true).GetBytes(data);
                fs.Write(info, 0, info.Length);
            }
            catch (IOException)
            {
                Console.WriteLine("An exception occured during writing to the file");
            }
        }
    }
}
