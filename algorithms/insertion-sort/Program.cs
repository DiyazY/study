using System;
using System.Linq;

namespace insertion_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[]{2,3,4,5,1,23,4,6,8,3,7};
            System.Console.WriteLine("init");
            System.Console.WriteLine(string.Join(",", array));
            array.InsertionSort();
            System.Console.WriteLine("sort");
            System.Console.WriteLine(string.Join(",", array));
            System.Console.WriteLine("sort decs");
            array.InsertionSortDecs();
            System.Console.WriteLine(string.Join(",", array));
         }
    }

    public static class ArrayExtension{
        public static void InsertionSort(this int[] array){
            for(int j=1; j<array.Length; j++){
                var key = array[j];
                int i = j-1;
                while (i>=0 && array[i]>key)
                {
                    array[i+1]=array[i];
                    i--;
                }
                array[i+1] = key;
            }
        }

        public static void InsertionSortDecs(this int[] array){
            for(int j=1; j<array.Length; j++){
                var key = array[j];
                int i = j-1;
                while (i>=0 && array[i]<key)
                {
                    array[i+1]=array[i];
                    i--;
                }
                array[i+1] = key;
            }
        }
    }
}
