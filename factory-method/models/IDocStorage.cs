using System;

namespace factory_method.models
{
    public interface IDocStorage{
        void Save(string name, string document);
        string Load(string name);
    }
}
