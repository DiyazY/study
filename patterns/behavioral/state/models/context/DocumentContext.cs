using System;

namespace state.models
{
    public class  DocumentContext:IDocument{
        private IDocument _state;
        public DocumentContext(IDocument initialState) => _state = initialState;

        public string GetData()
        {
            return _state.GetData();
        }

        public void Init(string value)
        {
            _state.Init(value);
        }

        public void setState(IDocument state){
            _state = state;
        }

        public bool Validate()
        {
            return _state.Validate();
        }
    }
}
