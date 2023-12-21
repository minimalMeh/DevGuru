using DevGuru.Core;
using System;

namespace DevGuru.Patterns.Compose
{
    public class CompositePattern : BasePattern
    {
        public override string Name => "Composite";
        protected override string DescriptionFormatted => "\t[Composes objects into tree structures to represent part-whole hierarchies,]\n\t[allowing clients to treat individual objects and compositions of objects uniformly.]\n";
        protected override string IdeaFormatted => "\t[FileSystem can contain either a file or a folder.]\n";

        protected override void RunCore()
        {
            var root = new Folder("ROOT:");

            var folderA = new Folder("A");
            FileSystem.Add(root, folderA);

            var fileA = new File("A.doc", 10);
            FileSystem.Add(folderA, fileA);

            var folderB = new Folder("B");
            FileSystem.Add(root, folderB);
            FileSystem.Add(folderB, new File("B.doc", 10));

            var fileB1 = new File("B.img", 20);
            FileSystem.Add(folderB, fileB1);

            var fileR = new File("R.db", 30);
            FileSystem.Add(root, fileR);
            FileSystem.Add(fileR, fileA);

            Console.WriteLine($"Size of {root.Name} node: {FileSystem.GetSize(root)}");
            FileSystem.Print(root);
        }
    }
}
