using System.Collections.Generic;

namespace DevGuru.Patterns.Compose
{
    public class Folder : IFileSystemNode
    {
        private readonly List<IFileSystemNode> children = new List<IFileSystemNode>();

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
    }
}
