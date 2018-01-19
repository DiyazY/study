using System;
using command.models;

namespace command
{
    class Program
    {
        static void Main(string[] args)
        {
            //watching TV
            TV tv = new TV();
            var pult = new multiFunctionalPult();
            pult.SetCommand(new TVCommand(tv));
            pult.PressEnter();
            pult.PressCancel();

            //go to the kitchen, turn on light and turn on fridge with temperature -10C , turn off light
            var lamp = new Lamp();
            var lampCommand = new LampCommand(lamp);
            pult.SetCommand(lampCommand);
            pult.PressEnter();

            var fm = new FreezingMachine();
            var fmCommand = new FreezingMachineCommand(fm,-10);
            pult.SetCommand(fmCommand);
            pult.PressEnter();

            pult.SetCommand(lampCommand);
            pult.PressCancel();
            Console.ReadLine();
        }
    }
}
