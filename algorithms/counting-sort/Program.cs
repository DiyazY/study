using System;

namespace counting_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse("5");
            var strarr = "2 3 9 2 9".Split(' ');
            var m = 11; // for 10 number [0,1,2,3,4,5,6,7,8,9,10] = 11 elements
            var a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(strarr[i]);
            }
            var sorted = CountingSort(a, n, m);
            for (int i = 0; i < n; i++)
            {
                Console.Write(sorted[i] + " ");
            }

        }

		/// arr - array, n - arr length, m - elements count 
        static int[] CountingSort(int[] arr, int n, int m) {
        	var count = new int[m];
        	var sorted = new int[n];
        	for (int i = 0; i < n; i++)
            {
                count[arr[i]] = count[arr[i]] + 1;
            }
            for (int i = 1; i < m; i++)
            {
                count[i] = count[i] + count[i - 1];
            }
            for (int i = n - 1; 0 <= i; i--)
            {
                sorted[count[arr[i]]-1] = arr[i];
                count[arr[i]] = count[arr[i]] - 1;
            }
            return sorted;
        }
    }
}
