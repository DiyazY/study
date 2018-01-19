
using System;
using System.Collections.Generic;

namespace observer.models
{
    interface IObservable
    {
        void AddObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers(string message);
    }

    class ConcreteObservable : IObservable
    {
        private List<IObserver> _observers;
        private string _name;
        public ConcreteObservable(string name)
        {
            _name = name;
            _observers = new List<IObserver>();
        }
        public void AddObserver(IObserver o)
        {
            _observers.Add(o);
        }
    
        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }
    
        public void NotifyObservers(string message)
        {
            System.Console.WriteLine($"{_name} send message:{message}");
            foreach (IObserver observer in _observers)
                observer.Update(message);
        }

        public void CreateEvent(string name){
            NotifyObservers($"{name}: new big event in {_name}");
        }
    }
}