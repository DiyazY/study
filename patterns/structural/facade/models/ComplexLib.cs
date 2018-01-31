using System;

namespace facade.models
{
    public class VideoFile
    {
        public string format {get;private set;}
        public VideoFile(string fileName){
            var arr = fileName.Split('.');
            format = arr[arr.Length-1];
        }
    }

    public class CodecFactory
    {
        public static IVideoCodec Extract(string format){
            if(format =="ogg")
                return new OggVideoCodec();
            if(format =="mp4")
                return new Mp4VideoCodec();
            return null;
        }
    }
    
    public interface IVideoCodec{
        void compress(VideoFile file);
    }

    public class OggVideoCodec: IVideoCodec{
        public void compress(VideoFile file)
        {
            System.Console.WriteLine("Ogg-codec : compress");
        }
    }

    public class Mp4VideoCodec : IVideoCodec
    {
        public void compress(VideoFile file)
        {
            System.Console.WriteLine("Mp4-codec : compress");
        }
    }

    public class CompressionVideo
    {
        private readonly VideoFile _file;
        private readonly IVideoCodec _codec;
        public CompressionVideo(VideoFile video,IVideoCodec codec){
            _file=video;
            _codec = codec;
        }

        public void Compress(){
            _codec.compress(_file);
        }
    }
}
