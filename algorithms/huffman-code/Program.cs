using System;
using System.Linq;

namespace huffman_code
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var unique = line.ToCharArray().Distinct();
            int count = unique.Count();
            Console.WriteLine(unique.Count());
            
        }
    }
}
