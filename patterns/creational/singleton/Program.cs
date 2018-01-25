using System;
using System.Threading;
using singleton.models;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                (new Thread(() =>
                {
                    var instance3 = SingletonObject.GetInstance();
                    instance3.print();
                    instance3.print();
                })).Start();

                var instance1 = SingletonObject.GetInstance();
                instance1.print();
                instance1.print();

                var instance2 = SingletonObject.GetInstance();
                instance2.print();
                instance2.print();
                System.Console.WriteLine($"they are equal 1 and 2 {Object.Equals(instance1,instance2)}");
            }
            System.Console.WriteLine($"thread safe singleton");
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                (new Thread(() =>
                {
                    var instance3 = ThreadSafeSingletonObject.GetInstance();
                    instance3.print();
                    instance3.print();
                })).Start();

                var instance1 = ThreadSafeSingletonObject.GetInstance();
                instance1.print();
                instance1.print();

                var instance2 = ThreadSafeSingletonObject.GetInstance();
                instance2.print();
                instance2.print();
                System.Console.WriteLine($"they are equal 1 and 2 {Object.Equals(instance1,instance2)}");
            }

            System.Console.WriteLine($"thread safe singleton without lock");
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                (new Thread(() =>
                {
                    var instance3 = ThreadSafeSingletonObjectWithOutLock.GetInstance();
                    instance3.print();
                    instance3.print();
                })).Start();

                var instance1 = ThreadSafeSingletonObjectWithOutLock.GetInstance();
                instance1.print();
                instance1.print();

                var instance2 = ThreadSafeSingletonObjectWithOutLock.GetInstance();
                instance2.print();
                instance2.print();
                System.Console.WriteLine($"they are equal 1 and 2 {Object.Equals(instance1,instance2)}");
            }

            System.Console.WriteLine($"thread safe singleton lazy implementation with nested class");
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                (new Thread(() =>
                {
                    var instance3 = ThreadSafeSingletonObjectNested.GetInstance();
                    instance3.print();
                    instance3.print();
                })).Start();

                var instance1 = ThreadSafeSingletonObjectNested.GetInstance();
                instance1.print();
                instance1.print();

                var instance2 = ThreadSafeSingletonObjectNested.GetInstance();
                instance2.print();
                instance2.print();
                System.Console.WriteLine($"they are equal 1 and 2 {Object.Equals(instance1,instance2)}");
            }


            System.Console.WriteLine($"thread safe singleton lazy<T>");
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                (new Thread(() =>
                {
                    var instance3 = ThreadSafeSingletonObjectLazyT.GetInstance();
                    instance3.print();
                    instance3.print();
                })).Start();

                var instance1 = ThreadSafeSingletonObjectLazyT.GetInstance();
                instance1.print();
                instance1.print();

                var instance2 = ThreadSafeSingletonObjectLazyT.GetInstance();
                instance2.print();
                instance2.print();
                System.Console.WriteLine($"they are equal 1 and 2 {Object.Equals(instance1,instance2)}");
            }

            
        }
    }
}
