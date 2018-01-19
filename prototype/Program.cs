using System;
using prototype.models;

namespace prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var soldier = new Soldier(1);
            soldier.Number = "2AEW2";
            var cloneSoldier = soldier.Clone() as Soldier;
            System.Console.WriteLine($"they are equal soldiers---> {Object.Equals(soldier,cloneSoldier)}");
            System.Console.WriteLine($"they are equal soldiers Numbers---> {Object.ReferenceEquals(soldier.Number,cloneSoldier.Number)}");
            cloneSoldier.Number = String.Copy("2AEW2");
            System.Console.WriteLine($"they are equal soldiers Numbers---> {Object.ReferenceEquals(soldier.Number,cloneSoldier.Number)}");
            System.Console.WriteLine($"");
            var square = new Figure(1,2);
            var square1 = square.Clone() as Figure;
            var square2 = square1.CloneShallow() as Figure;    
            var square3 = square1.CloneDeep() as Figure;       
            System.Console.WriteLine($"they are equal squares ---> {Object.Equals(square,square1)}");
            System.Console.WriteLine($"they are equal squares ---> {Object.Equals(square1,square2)}");
            System.Console.WriteLine($"they are equal squares ---> {Object.Equals(square2,square3)}");

            System.Console.WriteLine($"they are equal P ---> {Object.ReferenceEquals(square.P,square1.P)}");
            System.Console.WriteLine($"they are equal P ---> {Object.ReferenceEquals(square1.P,square2.P)}");
            System.Console.WriteLine($"they are equal P ---> {Object.ReferenceEquals(square2.P,square3.P)}");
        }
    }
}
