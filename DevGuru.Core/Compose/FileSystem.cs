namespace DevGuru.Core.Compose
{
    public class FileSystem
    {
        public int GetSize(IFileSystemNode fileSystemNode) => fileSystemNode.GetSize();

        public string GetPath(IFileSystemNode fileSystemNode) => fileSystemNode.Path;

        //public void Add(IFileSystemNode firstNode, IFileSystemNode secondNode)
        //{
        //    if (firstNode.IsComposite())
        //    {
        //        firstNode.Add(secondNode);
        //    }
        //}
    }
}
