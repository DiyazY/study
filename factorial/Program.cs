using System;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                string num = Console.ReadLine();
                int n;
                if(System.Int32.TryParse( num, out n)){
                    if(n<=0) System.Console.WriteLine($"Expected positive integer");
                    else{
                        Console.WriteLine($"Number: {n}");
                        try{  
                            checked
                            {
                                var watch = System.Diagnostics.Stopwatch.StartNew();

                                int result1 = factorial(n);
                            
                                watch.Stop();

                                Console.WriteLine($"Recursive !{n}={result1} ;ticks:{ watch.ElapsedTicks}");

                                watch.Start();

                                int result2 =1;

                                for(int i = 1;i<=n;i++){
                                    result2 = result2*i;
                                }
                            
                                watch.Stop();

                                Console.WriteLine($"Cycle !{n}={result2} ;ticks:{ watch.ElapsedTicks}");
                            }
                        }
                        catch (System.OverflowException ex)
                        {
                            Console.WriteLine($"CHECKED and CAUGHT: {ex.Message}{System.Environment.NewLine}DETAILS: {ex.ToString()}");
                        }
                    }
                }
                else{
                    Console.WriteLine($"Expected value should be integer numeric type");
                }
            }
        }

        private static int factorial(int n){
            checked
            {
                if(n==1) return 1;
                int t = n * factorial(n-1);
                return t;
            }
        }
    }
}
