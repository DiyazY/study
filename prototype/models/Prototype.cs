using System;

namespace prototype.models
{
    public abstract class Prototype
    {
        public Prototype(int id)
        {
            this.Id = id;
        }

        public int Id { get; private set; }

        public abstract Prototype Clone();
    }
}
