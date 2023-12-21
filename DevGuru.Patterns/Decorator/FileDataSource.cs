using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace DevGuru.Patterns.Decorator
{
    public class FileDataSource : IDataSource // Concrete Component
    {
        private readonly string fileName;
        private string Path => System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Decorator", fileName);

        public FileDataSource(string fileName)
        {
            this.fileName = fileName;
        }

        public string Read()
        {
            try
            {
                Console.WriteLine($"{nameof(FileDataSource)} Reading the file.");
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
                Console.WriteLine($"{nameof(FileDataSource)} Writing [\"{data}\"] to the file.");
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
