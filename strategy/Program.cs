using System;
using strategy.models;

namespace strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var ownerOne = new OwnerOne();
            var ownerTwo = new OwnerTwo();
            var store1 = new Store(1);
            store1.setOwner(ownerOne);
            store1.Sale("banana");
            var store2 = new Store(2);
            store2.setOwner(ownerOne);
            store2.Sale("phone");
            var store3 = new Store(4);
            store3.setOwner(ownerOne);
            store3.Sale("car");
            System.Console.ReadLine();
            var store4 = new Store(9);
            store4.setOwner(ownerTwo);
            store4.Sale("pen");
            var store5 = new Store(5);
            store5.setOwner(ownerTwo);
            store5.Sale("apple");
            var store6 = new Store(8);
            store6.setOwner(ownerTwo);
            store6.Sale("pc");
            System.Console.ReadLine();
        }
    }
}
