using System;

namespace bridge.maodels
{
    ///Abstraction
    public class Remote
    {
        protected IDevice _device;
        public Remote(IDevice device){
            _device = device;
        } 
        public void togglePower(){
            if(_device.isEnable())
                _device.disable();
            else 
                _device.enable();
        }
        public void VolumeDown(){
            _device.setVolume(_device.getVolume()-10);
        }
        public void VolumeUp(){
            _device.setVolume(_device.getVolume()+10);
        }

        public void chanelUp(){
            _device.setChanel(_device.getChanel()+1);
        }
        public void chanelDown(){
            _device.setChanel(_device.getChanel()-1);
        }
    }

    public class AdvancedRemote : Remote
    {
        public AdvancedRemote(IDevice device) : base(device)
        {
        }
        public void mute(){
            _device.setVolume(0);
        }
    }
}
