using System;

namespace state.models
{
    public interface IDocument{
        bool Validate();
        string GetData();
        void Init(string value);
    }
}
