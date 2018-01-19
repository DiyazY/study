using System;
using builder.models;

namespace builder
{
    class Program
    {
        static void Main(string[] args)
        {
            IBuilder builder = new DocumentA();
            Director director = new Director(builder);
            director.Construct();
            Product product = builder.GetResult();
            System.Console.WriteLine(product.j);

            builder = new DocumentB();
            director.setBuilder(builder);
            director.Construct();
            var documentB = builder.GetResult() as DocumentB.Document;
            System.Console.WriteLine($"{documentB.i} {documentB.j}");
        }
    }
}
