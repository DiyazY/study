using System;
using System.Collections.Generic;
using abstract_factory.models;

namespace abstract_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                IArmyFactory factory = null;
                Console.WriteLine("Choose army: USA or Russia!!! (type country)");
                string country = Console.ReadLine().Trim();

                if(country.Equals("usa",StringComparison.OrdinalIgnoreCase)){
                    factory = new UsaArmyFactory();
                }
                if(country.Equals("russia",StringComparison.OrdinalIgnoreCase)){
                    factory = new RusArmyFactory();
                }

                if(factory!=null){
                    System.Console.WriteLine("type qty of tanks");
                    int qty = Int32.Parse(Console.ReadLine().Trim());
                    List<ITank> tanks = new List<ITank>();
                    for (int i = 0; i < qty; i++)
                    {
                       tanks.Add(factory.CreateTank(i+1)); 
                    }

                    System.Console.WriteLine("type qty of flyes");
                    qty = Int32.Parse(Console.ReadLine().Trim());
                    List<IFly> flyes = new List<IFly>();
                    for (int i = 0; i < qty; i++)
                    {
                       flyes.Add(factory.CreateFly(i+1)); 
                    }

                    System.Console.WriteLine("type qty of fighters");
                    qty = Int32.Parse(Console.ReadLine().Trim());
                    List<IFighter> fighters = new List<IFighter>();
                    for (int i = 0; i < qty; i++)
                    {
                       fighters.Add(factory.CreateFighter(i+1));
                    }

                    System.Console.WriteLine("Fiiiiiiiiiiire!!!!!!!!!!!");
                    foreach(var fighter in fighters){
                        fighter.Run();
                        fighter.Fire();
                    }
                    foreach(var fly in flyes){
                        fly.Fly();
                        fly.Fire();
                    }
                    foreach(var tank in tanks){
                        tank.Move();
                        tank.Fire();
                    }

                    
                } 
            }

        }
    }
}
