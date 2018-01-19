using System;

namespace command.models
{
    //command
    public interface ICommand
    {
        void Execute();
        void Cancel();  
    }

    //invoker
    public class multiFunctionalPult{
        ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }
    
        public void PressEnter()
        {
            _command.Execute();
        }
        public void PressCancel()
        {
            _command.Cancel();
        }
    }

    #region TV

    //ConcreteCommand
    public class TVCommand:ICommand{
        TV _tv;
        public TVCommand(TV tv){
            _tv=tv;
        }
        public void Execute()
        {
            _tv.On();
        }
        public void Cancel()
        {
            _tv.Off();
        }

    }

    //reciever
    public class TV
    {
        public void Off()
        {
            System.Console.WriteLine("TV turned off");
        }

        public void On()
        {
            System.Console.WriteLine("TV turned on");
        }
    }
    #endregion

    #region Light

    public class Lamp{
        public void Off()
        {
            System.Console.WriteLine("Lamp turned off");
        }

        public void On()
        {
            System.Console.WriteLine("Lamp turned on");
        }
    }


    public class LampCommand:ICommand{
        Lamp _lamp;
        public LampCommand(Lamp lamp){
            _lamp=lamp;
        }
        public void Execute()
        {
            _lamp.On();
        }
        public void Cancel()
        {
            _lamp.Off();
        }

    }

    #endregion

    #region  freezing machine

    public class FreezingMachineCommand : ICommand
    {
        FreezingMachine _fm;
        int _temperature;
        public FreezingMachineCommand(FreezingMachine fm,int temperature)
        {
            _fm=fm;
            _temperature=temperature;
        }
        public void Cancel()
        {
            _fm.StopFreezing();
        }

        public void Execute()
        {
            _fm.StartFreezing(_temperature);
        }
    }
    public class FreezingMachine{
        public void StartFreezing(int temperature){
            System.Console.WriteLine($"freezing machine is started freeze with {temperature} t");
        }

        public void StopFreezing(){
            System.Console.WriteLine($"freezing machine is stopped freeze");
        }
    }
    #endregion
}
