using DevGuru.Patterns.Compose;

namespace DevGuru.Patterns.Composite
{
    internal interface IFileSystemNodeComposite : IFileSystemNode
    {
        void Add(IFileSystemNode node);
    }
}
