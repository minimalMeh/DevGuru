using System.Collections.Generic;

namespace DevGuru.Core.Compose
{
    public class Folder : IFileSystemNode
    {
        private readonly List<IFileSystemNode> children = new List<IFileSystemNode>();
        private readonly Folder parent = null;

        public string Name { get; }
        public string Path { get => $"{(parent == null ? Name + ":" : parent.Path + "\\" + Name)}"; }

        public Folder(string name, Folder parent)
        {
            Name = name;
            this.parent = parent;
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
