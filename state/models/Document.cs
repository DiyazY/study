using System;

namespace state.models
{
    public class  Document{

        public DateTime CreatedDate{get;} = DateTime.UtcNow;
        public string Data{get;set;}

        public void setData(string value){
            Data = $"Document Data: {value}";
        }
        
    }
}
