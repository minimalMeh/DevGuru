namespace DevGuru.Patterns.Compose
{
    public interface IFileSystemNode
    {
        string Name { get; }

        int GetSize();
        bool IsComposite();
        void Add(IFileSystemNode node);
    }
}
