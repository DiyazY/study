using System;

namespace bridge.maodels
{
    //Implementation
    public interface IDevice
    {
        bool isEnable();
        void enable();
        void disable();
        int getVolume();
        void setVolume(int volume);
        void setChanel(int chanel);
        int getChanel();
        void showSettings();

    }
    public class TV : IDevice
    {
        private bool _enable;
        private int _chanel;
        private int _volume;
        public void disable()
        {
            _enable=false;
        }

        public void enable()
        {
            _enable=true;
        }

        public int getChanel()
        {
            return _chanel;
        }

        public int getVolume()
        {
            return _volume;
        }

        public bool isEnable()
        {
            return _enable;
        }

        public void setChanel(int chanel)
        {
            System.Console.WriteLine($"tv-chanel-{chanel}");
            _chanel = chanel;
        }

        public void setVolume(int volume)
        {
            System.Console.WriteLine($"tv-valume-{volume}");
            _volume = volume;
        }

        public void showSettings()
        {
            System.Console.WriteLine($@"
                TV model samsung 2AED896-RU
                chanel: {_chanel}
                volume: {_volume}
                enable: {_enable}
            ");
        }
    }

    public class Radio : IDevice
    {
        private bool _enable;
        private int _chanel;
        private string _volume = "0";
        public void disable()
        {
            _enable=false;
        }

        public void enable()
        {
            _enable=true;
        }

        public int getChanel()
        {
            return _chanel;
        }

        public int getVolume()
        {
            return int.Parse(_volume.Replace("%",string.Empty));
        }

        public bool isEnable()
        {
            return _enable;
        }

        public void setChanel(int chanel)
        {
            System.Console.WriteLine($"radio-chanel-{chanel}");
            _chanel = chanel;
        }

        public void setVolume(int volume)
        {
            System.Console.WriteLine($"radio-volume-{volume}");
            _volume = $"{volume}%";
        }

        public void showSettings()
        {
            System.Console.WriteLine($@"
                chanel: {_chanel}
                volume: {_volume}
                enable: {_enable}
            ");
        }
    }
}
