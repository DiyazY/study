using System;
using factory_method.models;

namespace factory_method
{
    class Program
    {
        static void Main(string[] args)
        {

            DocumentManager docManager = new TxtDocumentManager();
            docManager.name = "name";
            docManager.Save("document la lal alalalala");
            System.Console.WriteLine($"get result: {docManager.Load("name")}{Environment.NewLine}"); 

            IDocStorage storage = docManager.CreateStorage();
            storage.Save("name1", "document");
            System.Console.WriteLine($"get result: {storage.Load("name1")}{Environment.NewLine}"); 

            docManager = new RtfDocumentManager();
            docManager.name = "name";
            docManager.Save("document la lal alalalala");
            System.Console.WriteLine($"get result: {docManager.Load("name")}{Environment.NewLine}"); 

            var DM = new DocumentManager_P();

            var txtStore = DM.CreateStorage(DocumentManager_P.StorageFormat.Txt);
            txtStore.Save("txtStore", "document saved by txtStore");
            System.Console.WriteLine($"get result: {txtStore.Load("txtStore")}{Environment.NewLine}"); 

            var rtfStore = DM.CreateStorage(DocumentManager_P.StorageFormat.Rtf);
            rtfStore.Save("rtfStore", "document saved by rtfStore");
            System.Console.WriteLine($"get result: {rtfStore.Load("rtfStore")}{Environment.NewLine}"); 


            DocumentManager docMan = new DocumentManagerGeneric<RtfDoc>();
            docMan.name = "docMan";
            docMan.Save("qwe qwe qwe");
            System.Console.WriteLine($"get result: {docMan.Load("docMan")}{Environment.NewLine}"); 
        }
    }
}
