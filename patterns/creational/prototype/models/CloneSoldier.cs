using System;

namespace prototype.models
{
    public class Soldier:  Prototype
    {
        public Soldier(int id) : base(id)
        {
        }

        public string Number{get;set;}

        public override Prototype Clone() => 
            new Soldier(this.Id){
            Number = String.Copy(this.Number)///this.Number
            };
    }
}
