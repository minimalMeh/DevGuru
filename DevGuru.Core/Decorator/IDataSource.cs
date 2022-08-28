namespace DevGuru.Core.Decorator
{
    public interface IDataSource // Component
    {
        void Write(string data);

        string Read();
    }
}
