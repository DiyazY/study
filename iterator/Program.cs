using System;
using iterator.models;

namespace iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Facebook socnet = new Facebook();
            Spamer spamer = new Spamer();
            spamer.SpamFriends(socnet);
            spamer.SpamKith(socnet);
            Console.Read();
        }
    }
}
