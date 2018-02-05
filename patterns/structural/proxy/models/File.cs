using System;
using System.Collections.Generic;
using System.Threading;

namespace proxy.models
{
    public class File: INotebook
    {
        private Dictionary<string,string> _store = new Dictionary<string,string>();

        //trick for emulate reading file
        private void _Sleep() => Thread.Sleep(2000);

        public string Read(string key)
        {
            _Sleep();
            string value = string.Empty;
            _store.TryGetValue(key,out value);
            System.Console.WriteLine($"read from file: {key}-{value}");
            return value;
        }


        public bool Write(string key, string value)
        {
            _Sleep();
            System.Console.WriteLine($"write to file: {key}-{value}");
            return _store.TryAdd(key,value);
        }
    } 
}
