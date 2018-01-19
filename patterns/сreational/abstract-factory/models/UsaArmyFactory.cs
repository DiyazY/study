using System;

namespace abstract_factory.models
{
    public class UsaArmyFactory : IArmyFactory
    {
        public IFighter CreateFighter(int number)
        {
            return new UsSoldier(number);
        }

        public IFly CreateFly(int number)
        {
            return new FlyF16(number);
        }

        public ITank CreateTank(int number)
        {
            return new TankAbram(number);
        }
    }

    public class TankAbram : ITank
    {
        private readonly int _number;
        public TankAbram(int number)
        {
            _number = number;
        }

        public void Fire()
        {
            System.Console.WriteLine($"Abram({_number}): bow bow bow!!!!");
        }

        public void Move()
        {
            System.Console.WriteLine($"Abram({_number}): 90 km/h");
        }
    }
    public class FlyF16 : IFly
    {
        private readonly int _number;
        public FlyF16(int number)
        {
            _number = number;
        }
        public void Fire()
        {
            System.Console.WriteLine($"F16({_number}): piuuu piuuu piuuu!!!");
        }

        public void Fly()
        {
            System.Console.WriteLine($"F16({_number}): 800 km/h");
        }
    }

    public class UsSoldier : IFighter
    {
        private readonly int _number;
        public UsSoldier(int number)
        {
            _number = number;
        }
        public void Fire()
        {
            System.Console.WriteLine($"Mk-16({_number}): tra ta ta ta ta!!!!");
        }

        public void Run()
        {
            System.Console.WriteLine($"Solder({_number}): 3 km/h");
        }
    }
}
