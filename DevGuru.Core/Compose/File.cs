namespace DevGuru.Core.Compose
{
    public class File : IFileSystemNode
    {
        private readonly int size;
        private readonly Folder parent;

        public string Name { get; private set; }
        public string Path { get => $"{parent.Path}\\{Name}"; }

        public File(string name, int size, Folder parent)
        {
            Name = name;
            this.size = size;
            this.parent = parent;
        }

        public int GetSize() => size;

        public bool IsComposite() => false;

        public void Add(IFileSystemNode node) { }
    }
}
