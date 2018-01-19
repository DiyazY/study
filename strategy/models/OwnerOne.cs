using System;

namespace strategy.models
{
    public class OwnerOne : IOwner
    {
        void IOwner.Sale(string good)
        {
            System.Console.WriteLine($"Owner number 1 sale {good}");
            System.Console.WriteLine($"gift bonus from Owner number 1");
        }
    }
}
