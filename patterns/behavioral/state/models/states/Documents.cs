using System;

namespace state.models
{
    public class pdfDocument :Document, IDocument
    {

        public string GetData()
        {
            return this.Data;
        }

        public void Init(string value)
        {
            this.setData($"pdf ====> {value}");
        }

        public bool Validate()
        {
            return this.Data.Contains("pdf");
        }
    }

    public class mediaDocument :Document, IDocument
    {

        public string GetData()
        {
            return $"=============={this.Data}===============";
        }

        public void Init(string value)
        {
            this.setData($"media ====> {value}");
        }

        public bool Validate()
        {
            return this.Data.Contains("media");
        }
    }

    public class textDocument :Document, IDocument
    {

        public string GetData()
        {
            return $"==============>>>>{this.Data}<<<<===============";
        }

        public void Init(string value)
        {
            this.setData($"text ====> {value}");
        }

        public bool Validate()
        {
            return this.Data.Contains("text");
        }
    }
}
