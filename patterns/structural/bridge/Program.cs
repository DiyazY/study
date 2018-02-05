using System;
using bridge.maodels;

namespace bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var tv = new TV();
            var tvRemote = new Remote(tv);    
            tv.showSettings();
            tvRemote.togglePower();
            tvRemote.chanelUp();
            tvRemote.chanelUp();
            tvRemote.VolumeUp();
            tvRemote.VolumeUp();
            tv.showSettings();

            var radio = new Radio();
            var radioRemote = new AdvancedRemote(radio);
            radio.showSettings();
            radioRemote.togglePower();
            radioRemote.chanelUp();
            radioRemote.chanelUp();
            radioRemote.VolumeUp();
            radioRemote.VolumeUp();
            radio.showSettings();
            radioRemote.mute();
            radio.showSettings();
        }
    }
}
