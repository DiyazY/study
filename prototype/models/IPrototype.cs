using System;

namespace prototype.models
{
    public interface IPrototype
    {
        IPrototype Clone();
    }

    public class Figure : IPrototype
    {
        public readonly int x;
        public readonly int y;
        public string P;
        public Figure(int x,int y){
            this.x = x;
            this.y = y;
            this.P=$"{x}+{y}={x+y}";
        }
        public IPrototype Clone(){
            return new Figure(this.x, this.y); 
        }

        public IPrototype CloneShallow(){
            return this.MemberwiseClone() as IPrototype;
        }
        public IPrototype CloneDeep(){
            var result = this.MemberwiseClone() as Figure;
            result.P = String.Copy(result.P);
            return result as IPrototype;
        }
    }


}
