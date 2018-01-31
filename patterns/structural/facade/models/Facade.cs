using System;

namespace facade.models
{
    public class VideoCompressFacade
    {
        private readonly VideoFile _file;
        public VideoCompressFacade(string filename){
            _file = new VideoFile(filename);
        }

        public void Compress(){
            var codec = CodecFactory.Extract(_file.format);
            var cmpVideo = new CompressionVideo(_file,codec);
            cmpVideo.Compress();
        }
    }
}
