using System;

namespace singleton.models
{
    public class SingletonObject
    {
        private static SingletonObject _instance;
        private int _printCount = 0;
        private string _name;

        private SingletonObject()
        {
            _name = Guid.NewGuid().ToString();
        }

        public static SingletonObject GetInstance(){
            if(_instance == null)
                _instance = new SingletonObject();
            return _instance;
        }

        public void print(){
            _printCount++;
            System.Console.WriteLine($"objectId {_name} print! {_printCount}");
        }
    }
}
