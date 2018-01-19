using System;
using state.models;

namespace state
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentContext doc = new DocumentContext(new pdfDocument());
            doc.Init("text text text");
            System.Console.WriteLine($"data: {doc.GetData()}");
            System.Console.WriteLine($"validate: {doc.Validate()}");
            doc.setState(new textDocument());
            doc.Init("pu pu pu");
            System.Console.WriteLine($"data: {doc.GetData()}");
            System.Console.WriteLine($"validate: {doc.Validate()}");
            doc.setState(new mediaDocument());
            doc.Init("media media media");
            System.Console.WriteLine($"data: {doc.GetData()}");
            System.Console.WriteLine($"validate: {doc.Validate()}");
        }
    }
}
