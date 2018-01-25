using System;
using memento.models;

namespace memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero();
        hero.Shoot(); // do shoot, 9 ammunition are left
        GameHistory game = new GameHistory(hero);
             
        game.Save();
 
        hero.Shoot(); //do shoot, 8 ammunition are left
        //hero die
        System.Console.WriteLine("hero die");
        game.Undo();
 
        hero.Shoot(); //do shoot, 8 ammunition are left
        game.Save();
        hero.Shoot(); //do shoot, 7 ammunition are left
        hero.Shoot(); //do shoot, 6 ammunition are left
        //hero die
        System.Console.WriteLine("hero die");
        game.Undo();
        hero.Shoot(); //do shoot, 8 ammunition are left

        Console.Read();
        }
    }
}
