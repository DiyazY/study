using System;

namespace singleton.models
{
    public class ThreadSafeSingletonObject
    {
        private static ThreadSafeSingletonObject _instance;
        private int _printCount = 0;
        private string _name;

        private static object syncRoot = new Object();

        private ThreadSafeSingletonObject()
        {
            _name = Guid.NewGuid().ToString();
        }

        public static ThreadSafeSingletonObject GetInstance(){
            if(_instance == null)
                lock (syncRoot)
                {
                    if(_instance == null)
                        _instance = new ThreadSafeSingletonObject();
                }
            return _instance;
        }

        public void print(){
            _printCount++;
            System.Console.WriteLine($"objectId {_name} print! {_printCount}");
        }
    }


    public class ThreadSafeSingletonObjectWithOutLock
    {
        private readonly static ThreadSafeSingletonObjectWithOutLock _instance = new ThreadSafeSingletonObjectWithOutLock();
        private int _printCount = 0;
        private string _name;

        private ThreadSafeSingletonObjectWithOutLock()
        {
            _name = Guid.NewGuid().ToString();
        }

        public static ThreadSafeSingletonObjectWithOutLock GetInstance(){
            return _instance;
        }

        public void print(){
            _printCount++;
            System.Console.WriteLine($"objectId {_name} print! {_printCount}");
        }
    }

    public class ThreadSafeSingletonObjectNested
    {
        private int _printCount = 0;
        private string _name;

        private ThreadSafeSingletonObjectNested()
        {
            _name = Guid.NewGuid().ToString();
        }

        public static ThreadSafeSingletonObjectNested GetInstance(){
            return Nested.instance;
        }

        public void print(){
            _printCount++;
            System.Console.WriteLine($"objectId {_name} print! {_printCount}");
        }
 
        private class Nested
        {
            internal static readonly ThreadSafeSingletonObjectNested instance = new ThreadSafeSingletonObjectNested();
        }
    }

    public class ThreadSafeSingletonObjectLazyT
    {
        private static readonly Lazy<ThreadSafeSingletonObjectLazyT> _lazy = 
        new Lazy<ThreadSafeSingletonObjectLazyT>(() => new ThreadSafeSingletonObjectLazyT());
        private int _printCount = 0;
        private string _name;

        private ThreadSafeSingletonObjectLazyT()
        {
            _name = Guid.NewGuid().ToString();
        }

        public static ThreadSafeSingletonObjectLazyT GetInstance(){
            return _lazy.Value;
        }

        public void print(){
            _printCount++;
            System.Console.WriteLine($"objectId {_name} print! {_printCount}");
        }

    }
}
