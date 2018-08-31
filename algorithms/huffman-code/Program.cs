using System;
using System.Collections.Generic;
using System.Linq;

namespace huffman_code
{
    class Program
    {
        

        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var array = line.ToCharArray();
            var unique = array.Distinct();
            int count = unique.Count();
            Console.WriteLine(unique.Count());
            
            List<Node> nodes = new List<Node>();
            foreach (var symbol in array)
            {
                nodes.Add(new Node(){Value=symbol, Frequency = array.Where(p=>p == symbol).Count()});
            }
            nodes = nodes.OrderBy(p=>p.Frequency).ToList();
            
        }
    }

    public struct Node {
        public char Value{get;set;}
        public int Frequency{get;set;}
    }
}
