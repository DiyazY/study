using System;

namespace string_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                string row = Console.ReadLine();
                var line = row.ToCharArray();
                Console.WriteLine($"String: {row}; Length: {line.Length}");

                var watch = System.Diagnostics.Stopwatch.StartNew();
                char temp;
                for (int i = 0, j = line.Length - 1; i < line.Length && i < j; i++, j--)
                {
                    temp = line[i];
                    line[i] = line[j];
                    line[j] = temp;
                }
                watch.Stop();

                Console.WriteLine($"String: {new string(line)}; Length: {line.Length}; ticks:{ watch.ElapsedTicks}");

                var line1 = row.ToCharArray();
                Console.WriteLine($"String: {row}; Length: {line1.Length}");

                watch.Start();
                Array.Reverse(line1);
                watch.Stop();

                Console.WriteLine($"String: {new string(line1)}; Length: {line1.Length}; ticks:{ watch.ElapsedTicks}");
            }
        }
    }
}
