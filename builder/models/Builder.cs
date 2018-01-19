using System;

namespace builder.models
{
    public interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        void BuildPartC();
        Product GetResult();
    }
    //product
    public abstract class Product
    {
        public int j=0;
    }

    public class DocumentA : IBuilder
    {
        public void BuildPartA()
        {
            System.Console.WriteLine($"DocumentA BuildPartA--->");
        }

        public void BuildPartB()
        {
            System.Console.WriteLine($"DocumentA BuildPartB--->");
        }

        public void BuildPartC()
        {
            System.Console.WriteLine($"DocumentA BuildPartC--->");
        }

        public Product GetResult()
        {
            return new Document(){i=10};
        }

        public class Document:Product{
            public int i = 0;
        }
    }

    public class DocumentB : IBuilder
    {
        public void BuildPartA()
        {
            System.Console.WriteLine($"DocumentB BuildPartA<===");
        }

        public void BuildPartB()
        {
            System.Console.WriteLine($"DocumentB BuildPartB<===");
        }

        public void BuildPartC()
        {
            System.Console.WriteLine($"DocumentB BuildPartC<===");
        }

        public Product GetResult()
        {
            return new Document(){j=10};
        }

        public class Document:Product{
            public string i = "B";
        }
    }
}
