using System;
using decorator.models;

namespace decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  Encryption > Compression > FileDataSource
                IDataSource source = new FileDataSource("somefile.dat");
                source.WriteData("Mike Johnes");
                System.Console.WriteLine($"read: {source.ReadData()}");

                

                source = new EncyptionDecorator(source);
                source.WriteData("This a Key");
                System.Console.WriteLine($"read: {source.ReadData()}");

                source = new CompressionDecorator(source);
                source.WriteData("It's freeeeeeeeeeeeezing!!!");
                System.Console.WriteLine($"read: {source.ReadData()}");
                source.Clear();

                source.WriteData("qqqqwwweasssssssdxsddffffs");
                System.Console.WriteLine($"read: {source.ReadData()}");
            #endregion
            
        }
    }
}
