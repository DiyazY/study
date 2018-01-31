using System;
using facade.models;

namespace facade
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoCompressFacade videoCompress = new VideoCompressFacade("qwe.mp4");
            videoCompress.Compress();
            videoCompress = new VideoCompressFacade("qwe.ogg");
            videoCompress.Compress();
        }
    }
}
