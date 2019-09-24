using System;
using System.Linq;

namespace number_of_inversions
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var arr = Console.ReadLine().Split(' ');
            var array = Array.ConvertAll(arr, long.Parse);
            long count = 0;
            var result = MergeSort(array, ref count);
            Console.WriteLine(count);
        }

        public static long[] MergeSort(long[] array, ref long countOfInversions)
        {
            if (array.Length == 1) return array;
            int mid = array.Length / 2;
            var left = array.Take(mid).ToArray();
            var right = array.Skip(mid).ToArray();
            long[] sortedArray;
            Merge(
                MergeSort(left, ref countOfInversions),
                MergeSort(right, ref countOfInversions),
                out sortedArray,
                ref countOfInversions);
            return sortedArray;
        }

        public static void Merge(long[] left, long[] right, out long[] merged, ref long countOfInversions)
        {
            long a = 0, b = 0;
            merged = new long[left.Length + right.Length];
            for (long i = 0; i < left.Length + right.Length; i++)
            {
                if (a == left.Length)
                {
                    merged[i] = right[b];
                    b++;
                }
                else
                if (b == right.Length)
                {
                    merged[i] = left[a];
                    a++;
                }
                else
                if (left[a] <= right[b])
                {
                    merged[i] = left[a];
                    a++;
                }
                else
                {
                    merged[i] = right[b];
                    b++;
                    countOfInversions += left.Length - a;
                }
            }
        }
    }
}
