using System;
using System.Collections.Generic;
using System.Linq;

namespace different_terms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();
            numbers.Push(1);
            int sum = 1;
            for (int i = 2; i <= n; i++)
            {
                if(i+sum > n) {
                    sum-=i-1;
                    numbers.Pop();
                }
                if(i+sum<=n){
                    sum+=i;
                    numbers.Push(i);
                }
                if (sum == n) break;
            }
            System.Console.WriteLine(numbers.Count);
            System.Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
