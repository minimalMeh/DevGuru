namespace DevGuru.Patterns.Compose
{
    public class FileSystem
    {
        public int GetSize(IFileSystemNode fileSystemNode) => fileSystemNode.GetSize();

        public void Add(IFileSystemNode firstNode, IFileSystemNode secondNode)
        {
            if (firstNode.IsComposite())
            {
                firstNode.Add(secondNode);
            }
        }
    }
}
