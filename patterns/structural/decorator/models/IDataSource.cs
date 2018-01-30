using System;
using System.Text.RegularExpressions;

namespace decorator.models
{
    public interface IDataSource
    {
        void WriteData(string data);
        string ReadData();

        void Clear();
    }

    public class FileDataSource : IDataSource
    {
        private readonly string _name;
        private string _data;
        public FileDataSource(string name){
            _name=name;
        }

        public void Clear()
        {
            _data=string.Empty;
        }

        public string ReadData()
        {
            return _data;
        }
        public void WriteData(string data)
        {
            System.Console.WriteLine(data);
            _data+=data;
        }
    }

    public abstract class DataSourceDecorator : IDataSource
    {
        protected IDataSource _wrappee;
        public DataSourceDecorator(IDataSource source){
            _wrappee = source;
        }
        public virtual string ReadData()
        {
            return _wrappee?.ReadData();
        }

        public virtual void WriteData(string data)
        {
            System.Console.WriteLine(data);
            _wrappee?.WriteData(data);
        }
        public void Clear()
        {
            _wrappee.Clear();
        }
    }

    public class EncyptionDecorator: DataSourceDecorator,IDataSource{
        public EncyptionDecorator(IDataSource source)
            :base(source){}
        public override void WriteData(string data)
        {
            System.Console.WriteLine("Encryption");
            data = $"@#${data}@#$";
            _wrappee?.WriteData(data);
        }
        public override string ReadData()
        {
            var encrypt = _wrappee?.ReadData();
            return encrypt.Replace("@#$",string.Empty);
        }
        
    }
    public class CompressionDecorator:DataSourceDecorator,IDataSource
    {
        public CompressionDecorator(IDataSource source)
            :base(source){}
        public override void WriteData(string data)
        {       
            System.Console.WriteLine("Compression");  
            data = Compress(data); 
            _wrappee?.WriteData(data);

            string Compress(string str) {
                return $"compressed{str}compressed";
            }
        }
        public override string ReadData()
        {
            var compress = _wrappee?.ReadData();
            return Decompress(compress);

            string Decompress(string str) {
                return str.Replace("compressed",string.Empty);
            }
        }
    }
}
