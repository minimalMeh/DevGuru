using DevGuru.Core;
using System;

namespace DevGuru.Patterns.Decorator
{
    public class DecoratorPattern : PatternBase
    {
        public override string Name => "Decorator";
        protected override string DescriptionFormatted => "\t[Attaches additional responsibilities to an object dynamically, providing]\n\t[a flexible alternative to subclassing for extending functionality.]\n";
        protected override string IdeaFormatted => "\t[File data source reads and writes the file information. The data is encrypted by the decorator.]\n";

        protected override void RunCore()
        {
            string info = "Some info to write: Name, Salary - John, 1000 - Lida, 2000";

            IDataSource encryptableDataSource = new EncryptionDecorator(new FileDataSource("test.txt"));
            encryptableDataSource.Write(info);

            IDataSource plainFileDataSource = new FileDataSource("test.txt");

            Console.WriteLine("Plain data source file read:" + plainFileDataSource.Read());
            Console.WriteLine("Decorator data source file read:" + encryptableDataSource.Read());
        }
    }
}
