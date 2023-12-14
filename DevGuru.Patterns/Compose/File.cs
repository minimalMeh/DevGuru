namespace DevGuru.Patterns.Compose
{
    public class File : IFileSystemNode
    {
        private readonly int size;

        public string Name { get; private set; }

        public File(string name, int size)
        {
            Name = name;
            this.size = size;
        }

        public int GetSize() => size;

        public bool IsComposite() => false;

        public void Add(IFileSystemNode node) { }
    }
}
