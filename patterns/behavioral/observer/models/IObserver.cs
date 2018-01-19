
using System;

namespace observer.models
{
    interface IObserver
    {
        void Update(string message);
    }

    class PersonObserver :IObserver
    {
        private string _name;
        public PersonObserver(string name){
            _name = name;
        }
        public void Update(string message)
        {
            System.Console.WriteLine($"{new String('-', 3)}{_name} get message: {message}");
        }
    }

    class CompanyObserver :IObserver
    {
        private string _name;
        public CompanyObserver(string name){
            _name = name;
        }
        public void Update(string message)
        {
            System.Console.WriteLine($"{new String('-', 2)}{_name} get message: {message}");
        }
    }
}