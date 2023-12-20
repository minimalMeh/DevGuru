using DevGuru.Patterns.Composite;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DevGuru.Patterns.Compose
{
    [DebuggerDisplay("Name: {Name}, Size = {GetSize()}")]
    public class Folder : IFileSystemNodeComposite
    {
        private readonly List<IFileSystemNode> children = new();

        public string Name { get; }

        public Folder(string name)
        {
            Name = name;
        }

        public void Add(IFileSystemNode node)
        {
            children.Add(node);
        }

        public int GetSize()
        {
            int size = 0;
            children.ForEach(f => size += f.GetSize());
            return size;
        }

        public bool IsComposite() => true;

        public void Print()
        {
            Console.Write($" Folder: {Name} ");

            Console.Write('(');

            foreach (IFileSystemNode node in children)
            {
                node.Print();
            }

            Console.Write(')');
        }
    }
}
