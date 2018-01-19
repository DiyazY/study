using System;
using proxy.models;

namespace proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            INotebook notebook = new CacheProxy();
            notebook.Write("dima","+79098542296");
            notebook.Write("mike","+19062583654");
            notebook.Write("damir","+23658541123");
            notebook.Write("rob","+77777777777");
            
            notebook.Read("dima");
            notebook.Read("dima");
            notebook.Read("mike");
            notebook.Read("mike");
            notebook.Read("damir");
            notebook.Read("rob");
            notebook.Read("rob");
        }
    }
}
