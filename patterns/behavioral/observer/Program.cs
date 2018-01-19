using System;
using observer.models;

namespace observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var co1 = new ConcreteObservable("nike");
            var co2 = new ConcreteObservable("adidas");

            var person1 = new PersonObserver("pavel");
            var person2 = new PersonObserver("damir");
            var person3 = new PersonObserver("ivan");
            var person4 = new PersonObserver("serik");

            co1.AddObserver(person1);
            co1.AddObserver(person2);
            co1.AddObserver(person3);
            System.Console.WriteLine();
            co2.AddObserver(person3);
            co2.AddObserver(person4);
            System.Console.WriteLine();
            co1.NotifyObservers("Sale in nike store!!!");
            co2.NotifyObservers("black friday in adidas!!!");
            System.Console.WriteLine();
            co1.RemoveObserver(person1);

            co1.NotifyObservers("black friday in nike!!!");
            System.Console.WriteLine();
            var company1 = new CompanyObserver("google");
            var company2 = new CompanyObserver("facebook");

            co2.AddObserver(company1);
            co2.AddObserver(company2);

            co2.NotifyObservers("Happy New Year!!!");
            System.Console.WriteLine();
            co1.CreateEvent("party");
            System.Console.WriteLine();
            co2.CreateEvent("birthday");
        }
    }
}
