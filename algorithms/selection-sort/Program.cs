using System;

namespace selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[]{2,3,4,5,1,23,4,6,8,3,7};
            System.Console.WriteLine("init");
            System.Console.WriteLine(string.Join(",", array));
            array.SelectionSort();
            System.Console.WriteLine("sort");
            System.Console.WriteLine(string.Join(",", array));
        }
    }

    public static class ArraySort{
        public static void SelectionSort(this int[] array){
            for(int i=0; i<array.Length-1;i++){
                var min = array[i];
                var index = i;
                for(int j = i+1; j<array.Length;j++){
                    if(min>array[j]){
                        min=array[j];
                        index = j;
                    }
                }
                if(index!=i){
                    array[index]=array[i];
                    array[i]=min;
                } 
            }
        } 
    }
}
