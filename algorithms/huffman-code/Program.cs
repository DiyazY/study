using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace huffman_code
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var array = line.ToCharArray();
            var unique = array.Distinct();
            List<Node> nodes = new List<Node>();
            int i = 0;
            foreach (var symbol in unique)
            {
                nodes.Add(new Node() { Id = i, Value = symbol, Frequency = array.Where(p => p == symbol).Count() });
                i++;
            }
            nodes = nodes.OrderByDescending(p => p.Frequency).ToList();
            while (nodes.Count != 1)
            {
                var node1 = nodes.Aggregate((i1, i2) => i1.Frequency < i2.Frequency ? i1 : i2);
                nodes.Remove(node1);
                var node2 = nodes.Aggregate((i1, i2) => i1.Frequency < i2.Frequency ? i1 : i2);
                nodes.Remove(node2);
                Node parent = null;
                if (node1.Frequency == node2.Frequency)
                {
                    parent = Node.CreateParent(node2, node1);
                }
                else
                {
                    parent = Node.CreateParent(node1, node2);
                }
                nodes.Add(parent);
            }
            var root = nodes[0];
            var path = new Stack<string>();
            path.Push(string.Empty);
            DFS dFS = new DFS();
            dFS.dictionary = new Dictionary<char, string>();
            dFS.path = path;
            dFS.CLR(root);
            StringBuilder builder = new StringBuilder();
            foreach (var item in array)
            {
                builder.Append(dFS.dictionary[item] == string.Empty ? "0" : dFS.dictionary[item]);
            }
            Console.WriteLine($"{unique.Count()} {builder.Length}");
            foreach (var item in dFS.dictionary)
            {
                var letter = item.Value == string.Empty ? "0" : item.Value;
                Console.WriteLine($"{item.Key}: {letter}");
            }
            System.Console.WriteLine(builder.ToString());
        }
    }

    public class DFS
    {
        public Stack<string> path = null;
        public Dictionary<char, string> dictionary = null;
        public void CLR(Node node)
        {
            if (node == null) return;
            if (node.LeftNode != null)
            {
                path.Push(path.Peek() + "0");
                CLR(node.LeftNode);
            }
            if (node.RightNode != null)
            {
                path.Push(path.Peek() + "1");
                CLR(node.RightNode);
            }
            if (node.Value != null)
            {
                dictionary.Add((char)node.Value, path.Peek());
            }
            path.Pop();
        }
    }



    public class Node
    {
        public int Id { get; set; }
        public char? Value { get; set; }
        public int Frequency { get; set; }
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
        public static Node CreateParent(Node leftNode, Node rightNode)
        {
            var node = new Node()
            {
                Frequency = leftNode.Frequency + rightNode.Frequency,
                RightNode = rightNode,
                LeftNode = leftNode
            };
            return node;
        }
    }
}
