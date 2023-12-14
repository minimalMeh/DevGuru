using System;
using System.Text;

namespace DevGuru.Patterns.Decorator
{
    public class EncryptionDecorator : DataSourceDecorator
    {
        public EncryptionDecorator(IDataSource dataSource) : base(dataSource)
        {
        }

        public override string Read()
        {
            return Decode(base.Read());
        }

        public override void Write(string data)
        {
            base.Write(Encode(data));
        }

        private string Encode(string data)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(data);
            return Convert.ToBase64String(plainTextBytes);
        }

        private string Decode(string data)
        {
            var plainTextBytes = Convert.FromBase64String(data);
            return Encoding.UTF8.GetString(plainTextBytes);
        }
    }
}
