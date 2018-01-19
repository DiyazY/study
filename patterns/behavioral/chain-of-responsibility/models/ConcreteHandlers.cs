using System;

namespace chain_of_responsibility.models
{

    public class CalculateOrders : BaseHandler
    {
        private readonly string _currency;
        public CalculateOrders(string currency)
        {
            _currency = currency;
        }

        public override void Handle(Invoice request)
        {
            if(request!=null){
                var total = request.ItemPrice * request.Count;
                if(total == 0){
                    System.Console.WriteLine($"Wrong total {total}");
                    return;
                }
                request.Totals = $"{total} {_currency}";
                System.Console.WriteLine($"Total ={total}");
            }
            base.Handle(request);
        }
    }

    public class CheckNames:BaseHandler
    {
        public override void Handle(Invoice request)
        {
            if(request!=null){
                if(string.IsNullOrEmpty(request.FirstName)||string.IsNullOrEmpty(request.LastName)){
                    System.Console.WriteLine($"FirstName and LastName is required!!!");
                    return;
                }
                System.Console.WriteLine($"FullName = {request.FirstName} {request.LastName}");
            }
            base.Handle(request);
        }
    }

    public class GenerateInvoice:BaseHandler{
        public override void Handle(Invoice request)
        {
            if(request!=null){
                request.Date = DateTime.Now;
                System.Console.WriteLine("-----------------Invoice");
                System.Console.WriteLine($"FullName = {request.FirstName} {request.LastName}");
                System.Console.WriteLine($"Totals = {request.Totals}");
                System.Console.WriteLine($"Date = {request.Date.ToShortDateString()}");
            }
            base.Handle(null);
        }
    }
}
