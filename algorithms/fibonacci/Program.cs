using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            int first = 0;
            int second = 1;
            for(int i=2;i<=n;i++){
                result = first + second;
                first = second;
                second = result;
            }
            Console.WriteLine(result);
        }
    }
}
