using System;
using System.Collections.Generic;

//abstract method or method from interface
namespace factory_method.models
{
    public abstract class DocumentManager
    {
        public abstract IDocStorage CreateStorage();
        public string name;
    
        public bool Save(string document)
        {
    
            // using Factory method to create a new document storage
            IDocStorage storage = this.CreateStorage();
    
            storage.Save(name, document);
            
            return true;
        }
        public string Load(string name)
        {
    
            // using Factory method to create a new document storage
            IDocStorage storage = this.CreateStorage();
    
            return storage.Load(name);
        }
    }

    #region txt
        public class TxtDocumentManager : DocumentManager
        {
            public override IDocStorage CreateStorage() { 
                System.Console.WriteLine($"Created by {typeof(TxtDocumentManager).ToString()}");
                return new TxtDocStorage(); 
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
        
    #endregion
    
    #region rtf
        public class RtfDocumentManager : DocumentManager
        {
            public override IDocStorage CreateStorage() { 
                System.Console.WriteLine($"Created by {typeof(RtfDocumentManager).ToString()}");
                return new RtfDocStorage(); 
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
        }
        
    #endregion
    
    
}
