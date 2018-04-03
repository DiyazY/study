using System;

namespace binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Insert row of numbers");
            string row = Console.ReadLine();
            var line = Array.ConvertAll(row.Split(' '),Int32.Parse);
            Array.Sort(line);
            Console.WriteLine($"Sorted row of numbers: {string.Join(",", line)}"); 
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                Console.WriteLine($"Search   number");
                int number = Int32.Parse(Console.ReadLine());

                var watch = System.Diagnostics.Stopwatch.StartNew();
                var result1 = _binarySearch(line, number);
                watch.Stop();
                
                Console.WriteLine($"Position: {result1}; Length: {line.Length}; ticks:{ watch.ElapsedTicks}"); 

                watch.Start();
                var result2 = _bruteForceSearch(line, number);
                watch.Stop();
                
                Console.WriteLine($"Position: {result2}; Length: {line.Length}; ticks:{ watch.ElapsedTicks}");  

                

            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                Console.WriteLine($"Squaer   number");
                var sqNumber = Double.Parse(Console.ReadLine());
                double delta = 0.0001;

                var watch = System.Diagnostics.Stopwatch.StartNew();
                var result3 = _squareBruteForce(sqNumber,delta);
                watch.Stop();
                
                Console.WriteLine($"Square: {result3}; ticks:{ watch.ElapsedTicks}"); 

                watch.Start();
                var result4 = _squareBinary(sqNumber,delta);
                watch.Stop();
                
                Console.WriteLine($"Square: {result4}; ticks:{ watch.ElapsedTicks}"); 
            }
        }


        private static int? _binarySearch(int[] numbers, int value){
                int low = 0;
                int high = numbers.Length - 1;
                int iterations = 0;
                while(low<=high){
                    iterations++;
                    int middle = (low+high)/2;
                    if(value == numbers[middle]){
                        System.Console.WriteLine($"Value {value} is located at index of {middle}. Iterations: {iterations}");
                        return middle;
                    }
                    else if(value > numbers[middle]){
                        low = middle+1;
                    }
                    else {
                        high = middle-1;
                    }
                }
                return null;
        }

        private static int? _bruteForceSearch(int[] numbers, int value){
            for(int i=0;i<numbers.Length;i++){
                if(value==numbers[i]){
                    System.Console.WriteLine($"Value {value} is located at index of {i}. Iterations: {i+1}");
                    return i;
                }
            }
            return null;
        }

        private static double? _squareBruteForce(double a, double delta = 0.001){
            double ans = 0.0;
            int iterations = 0;
            while(Math.Abs(Math.Pow(ans,2)-a)>=delta){
                ans+=0.000001;
                iterations++;
            }
            if(Math.Abs(Math.Pow(ans,2)-a)>=delta){
                System.Console.WriteLine($"failed... {iterations}");
                return null;
            }
            else{
                System.Console.WriteLine($"{ans} close to square root of {a} with {iterations} number of guesses");
            }
            return ans;
        }

        private static double? _squareBinary(double a,double delta = 0.001){
            int iterations = 0;
            double low = 0.0;
            double high = a;
            double middle = (high+low)/2.0;
            while((Math.Abs(Math.Pow(middle,2)-a))>=delta){
                if(Math.Pow(middle,2)<a){
                    low = middle;
                } else{
                    high = middle;
                }
                middle = (high+low)/2.0;
                iterations++;
            }
            System.Console.WriteLine($"{middle} close to square root of {a} with {iterations} number of guesses");
            return middle;
        }
    }
}
