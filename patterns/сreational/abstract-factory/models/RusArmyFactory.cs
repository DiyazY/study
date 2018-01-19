using System;

namespace abstract_factory.models
{
    public class RusArmyFactory : IArmyFactory
    {
        public IFighter CreateFighter(int number)
        {
            return new RuSoldier(number);
        }

        public IFly CreateFly(int number)
        {
            return new FlySu51(number);
        }

        public ITank CreateTank(int number)
        {
            return new TankT44(number);
        }
    }

    public class TankT44 : ITank
    {
        private readonly int _number;
        public TankT44(int number){
            _number = number;
        }
        public void Fire()
        {
            System.Console.WriteLine($"T-44({_number}): bow bow bow!!!!");
        }

        public void Move()
        {
            System.Console.WriteLine($"T-44({_number}): 100 km/h");
        }
    }
    public class FlySu51 : IFly
    {
        private readonly int _number;
        public FlySu51(int number){
            _number = number;
        }
        public void Fire()
        {
            System.Console.WriteLine($"Su51({_number}): piuuu piuuu piuuu!!!");
        }

        public void Fly()
        {
            System.Console.WriteLine($"Su51({_number}): 800 km/h");
        }
    }

    public class RuSoldier : IFighter
    {
        private readonly int _number;
        public RuSoldier(int number){
            _number = number;
        }

        public void Fire()
        {
            System.Console.WriteLine($"Ak-47{_number}: tra ta ta ta ta!!!!");
        }

        public void Run()
        {
            System.Console.WriteLine($"Solder{_number}: 5 km/h");
        }
    }
}
