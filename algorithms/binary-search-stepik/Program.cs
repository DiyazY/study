using System;
using System.Linq;

namespace binary_search_stepik
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine().Split(" ");
            var n = int.Parse(firstLine[0]);
            int[] array = new int[n];
            for (int i = 1; i < firstLine.Length; i++)
            {
                    array[i-1] = int.Parse(firstLine[i]);
            }
            var secondLine = Console.ReadLine().Split(" ");
            var k = int.Parse(secondLine[0]);
            int[] result = new int[k];
            for (int i = 1; i < secondLine.Length; i++)
            {
                result[i - 1] = BSearch(array, int.Parse(secondLine[i]));
            }
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]+ " ");
            }
        }

        

        public static int BSearch(int[] numbers, int value)
        {
            int low = 0;
            int high = numbers.Length - 1;
            int iterations = 0;
            while (low <= high)
            {
                iterations++;
                int middle = (low + high) / 2;
                if (value == numbers[middle])
                {
                    return middle + 1;
                }
                else if (value > numbers[middle])
                {
                    low = middle + 1;
                }
                else
                {
                    high = middle - 1;
                }
            }
            return -1;
        }
    }
}
