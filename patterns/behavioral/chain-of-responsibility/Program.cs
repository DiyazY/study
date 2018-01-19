using System;
using chain_of_responsibility.models;

namespace chain_of_responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderBlank = new Invoice{
                FirstName="Diyaz",
                ItemPrice=100,
                Count = 3
            };

            var chain = new CheckNames();
            var secondChain = new CalculateOrders("usd");
            chain.SetHandler(secondChain);
            var thirdChain = new GenerateInvoice();
            secondChain.SetHandler(thirdChain);

            chain.Handle(orderBlank);
            System.Console.WriteLine($"modify order{Environment.NewLine}");
            orderBlank.LastName ="Yakubov";
            orderBlank.Count = 0;
            chain.Handle(orderBlank);
            System.Console.WriteLine($"modify order{Environment.NewLine}");
            orderBlank.Count = 5;
            chain.Handle(orderBlank);
        }
    }
}
