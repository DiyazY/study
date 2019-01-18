using System;
using System.Collections.Generic;
using System.Linq;

namespace priority_queue
{
    class Program
    {
        static void Main(string[] args)
        {
            int operationCount = int.Parse(Console.ReadLine());
            List<int> heap = new List<int>();
            for (int i = 0; i < operationCount; i++)
            {
                var command = Console.ReadLine();
                switch (command)
                {
                    case ("ExtractMax"):
                        if(heap.Count > 0){
                            System.Console.WriteLine(heap[0]);
                            heap.RemoveAt(0);
                        }

                        break;
                    default:
                        var value = int.Parse(command.Split(' ')[1]);
                        siftUp(heap, value);
                        break;
                }
            }
        }

        static void siftUp(List<int> heap, int value){
                var currentIndex =  heap.Count;
                heap.Add(value);
                
                bool sift = true;
                while(sift){
                    var parentIndex = (int)currentIndex/2;
                    if (heap[parentIndex] >= heap[currentIndex]) {
                        sift = false;
                    } else {
                        var temp = heap[currentIndex];
                        heap[currentIndex] = heap[parentIndex];
                        heap[parentIndex] = temp;
                        currentIndex = parentIndex;
                    }
                }  
            }
    }
}
