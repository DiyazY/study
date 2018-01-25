using System;

namespace abstract_factory.models
{
    public interface IArmyFactory
    {
        ITank CreateTank(int number);
        IFly CreateFly(int number);
        IFighter CreateFighter(int number);                 
    }

    public interface ITank
    {
        void Move();
        void Fire();
    }
    public interface IFly
    {
        void Fly();
        void Fire();
    }

    public interface IFighter
    {
        void Run();
        void Fire();
    }
}
