namespace DevGuru.Core.Compose
{
    public interface IFileSystemNode
    {
        string Name { get; }
        string Path { get; }

        int GetSize();
        bool IsComposite();
        void Add(IFileSystemNode node);
    }
}
