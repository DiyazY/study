using System;

namespace chain_of_responsibility.models
{
    public interface IHandler
    {
        void SetHandler(IHandler handler);
        void Handle(Invoice request);      
    }


    public abstract class BaseHandler : IHandler
    {
        protected IHandler _next;
        public virtual void Handle(Invoice request){
            if(_next!=null){
                _next.Handle(request);
            }
            else{
                System.Console.WriteLine($"Done!!!");
            }
        }

        public void SetHandler(IHandler handler)
        {
            _next = handler;
        }
    }

    public class Invoice{
        public string FirstName{get;set;}
        public string LastName{get;set;}
        public int ItemPrice{get;set;}
        public int Count{get;set;}

        //#################################
        public string Totals{get;set;}
        public DateTime Date{get;set;}
    }
}
