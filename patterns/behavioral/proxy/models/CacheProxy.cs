using System;
using System.Collections.Generic;
using System.Threading;

namespace proxy.models
{
    public class CacheProxy: INotebook
    {
        private Dictionary<string,string> _cache;
        private File _file;

        public CacheProxy()
        {
            _cache = new Dictionary<string,string>();
            _file = new File();
        }

        public string Read(string key)
        {
            string value = string.Empty;
            _cache.TryGetValue(key,out value);
            if(!string.IsNullOrEmpty(value)){
                System.Console.WriteLine($"get from cache: {key}-{value}");
                return value;
            }
            value = _file.Read(key);
            _cache.Add(key,value);
            return value;

        }

        public bool Write(string key, string value)
        {
            return _file.Write(key,value);
        }
    } 
}
