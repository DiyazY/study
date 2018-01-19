using System;

namespace strategy.models
{
    public class OwnerTwo : IOwner
    {
        void IOwner.Sale(string good)
        {
            System.Console.WriteLine($"Owner number 2 sale {good}");
        }
    }
}
