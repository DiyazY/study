using System;

namespace proxy.models
{
    public interface INotebook
    {
        string Read(string key);
        bool Write(string key, string value);
    } 
}
