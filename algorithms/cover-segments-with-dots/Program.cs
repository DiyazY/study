using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cover_segments_with_dots
{
    class Program
    {
        class Point
        {

            public int Value { get; set; }
            public bool Right { get; set; }
            public int SegmentNumber {get;set;}
        }
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n*2];
            for (int i = 0; i < n; i++)
            {
                var numbers = Console.ReadLine().Split(' ');
                points[i*2] = new Point() {Value = int.Parse(numbers[0]), Right=false, SegmentNumber = i};
                points[i*2+1] = new Point() {Value = int.Parse(numbers[1]), Right=true, SegmentNumber = i};
            }
            points = points.ToList().OrderBy(p=>p.Right).OrderBy(p => p.Value).ToArray();
            
            // for (int i = 0; i < n; i++)
            // {
            //     var side = points[i*2].Right ? 'R':'L';
            //     System.Console.WriteLine($"{points[i*2].Value}-{ side}");
            //     side = points[i*2+1].Right ? 'R':'L';
            //     System.Console.WriteLine($"{points[i*2+1].Value}-{ side }");
            // }

            bool[] coverage = new bool[n];

            int count = 0;
            StringBuilder stringBuilder = new StringBuilder();

            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n*2; i++)
            {
                if (points[i].Right) {
                    
                    if(!coverage[points[i].SegmentNumber]){
                        count++;
                        stringBuilder.Append(points[i].Value + " ");
                        coverage[points[i].SegmentNumber] = true;
                        while(stack.Count>0){
                            var segment = stack.Pop();
                            coverage[segment] = true;
                        }
                    }
                }
                else {
                    stack.Push(points[i].SegmentNumber);
                }
            }
            Console.WriteLine(count);
            Console.WriteLine(stringBuilder.ToString().TrimEnd());    
        } 
    }
}
