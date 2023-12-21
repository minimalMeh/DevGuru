namespace DevGuru.Patterns.Decorator
{
    public interface IDataSource // Component
    {
        void Write(string data);
        string Read();
    }
}
