using System;
using System.Collections.Generic;

namespace factory_method.models
{
    public class DocumentManagerGeneric<T> : DocumentManager where T : IDocStorage, new()
    {
        public override IDocStorage CreateStorage()
        {
            System.Console.WriteLine($"Created by {typeof(DocumentManagerGeneric<T>).ToString()}");
            IDocStorage storage = new T();
            // TODO: Setup, test, or do something else with the storage, if required.
            return storage;
        }
    }

    public class DocumentManager_G
    {
        private IDocStorage _storage;
    
        public void SetStorage<T>() where T : IDocStorage, new()
        {
            this._storage = new T();
            // TODO: Setup, test, or do something else with the storage, if required.
        }
    }

    public class RtfDoc : IDocStorage
    {
        private static Dictionary<string,string> _storage = new Dictionary<string, string>(); 
        public string Load(string name)
        {
            System.Console.WriteLine($"rtf load from {name}.rtf");
            return _storage.GetValueOrDefault($"{name}.rtf");       
        }

        public void Save(string name, string document)
        {
            System.Console.WriteLine($"rtf save {name}.rtf : {document}");
            _storage.TryAdd($"{name}.rtf",document);    
        }
    }

    public class TxtDoc : IDocStorage
    {
        private static Dictionary<string,string> _storage = new Dictionary<string, string>(); 
        public string Load(string name)
        {
            System.Console.WriteLine($"txt load from {name}.txt");
            return _storage.GetValueOrDefault($"{name}.txt");       
        }

        public void Save(string name, string document)
        {
            System.Console.WriteLine($"txt save {name}.txt : {document}");
            _storage.TryAdd($"{name}.txt",document);    
        }
    }
}
