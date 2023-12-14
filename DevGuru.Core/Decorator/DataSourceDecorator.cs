namespace DevGuru.Core.Decorator
{
    public abstract class DataSourceDecorator : IDataSource // Base decorator
    {
        protected IDataSource dataSource; // wrappee

        public DataSourceDecorator(IDataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public virtual string Read()
        {
            return dataSource.Read();
        }

        public virtual void Write(string data)
        {
            dataSource.Write(data);
        }
    }
}
