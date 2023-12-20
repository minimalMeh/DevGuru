using DevGuru.Patterns.Composite;
using System;

namespace DevGuru.Patterns.Compose
{
    public static class FileSystem
    {
        public static int GetSize(IFileSystemNode fileSystemNode) => fileSystemNode.GetSize();

        public static void Print(IFileSystemNode fileSystemNode)
        {
            Console.WriteLine($"Node {fileSystemNode.Name} file system:");
            fileSystemNode.Print();
            Console.WriteLine();
        }

        public static void Add(IFileSystemNode firstNode, IFileSystemNode secondNode)
        {
            if (firstNode.IsComposite())
            {
                (firstNode as IFileSystemNodeComposite)?.Add(secondNode);
            }
        }
    }
}
