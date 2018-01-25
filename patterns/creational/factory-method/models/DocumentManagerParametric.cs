using System;
using System.Collections.Generic;

namespace factory_method.models
{
    public class DocumentManager_P
    {
        public enum StorageFormat { Txt, Rtf }
    
        public IDocStorage CreateStorage(StorageFormat format)
        {
            System.Console.WriteLine($"Created by {typeof(DocumentManager_P).ToString()}");
            switch (format) {
                case StorageFormat.Txt:
                    return new TxtDocStorage();
        
                case StorageFormat.Rtf:
                    return new RtfDocStorage();
        
                default:
                    throw new ArgumentException($"An invalid format: {format.ToString()}");
            }
        }
        private class RtfDocStorage : IDocStorage
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

        private class TxtDocStorage : IDocStorage
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

    
}

