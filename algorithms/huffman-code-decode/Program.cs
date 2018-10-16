using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace huffman_code_decode
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = Console.ReadLine().Split(' ').ToArray();
            var dictionary = new Dictionary<string, string>();
            var countOfSymb = int.Parse(lines[0]);
            for (int j = 0; j < countOfSymb; j++)
            {
                var values = Console.ReadLine().Split(':');
                dictionary.Add(values[1].Trim(), values[0].Trim());
            }

            string value = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            int countOfletters = int.Parse(lines[1]);
            for (int i = 0; i < countOfletters; i++)
            {
                for (int j = 0; j < value.Length; j++)
                {
                    string val;
                    if (dictionary.TryGetValue(value.Substring(0, j + 1), out val))
                    {
                        result.Append(val);
                        value = value.Remove(0, j + 1);
                        break;
                    }
                } 
            }
            Console.WriteLine(result.ToString());
        }
    }
}
