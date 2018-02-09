using System;

namespace composite.models
{
    public class Dot : IGraphic
    {
        private int _x,_y;

        public Dot(int x, int y){
            this._x = x;
            this._y = y;
        }

        public void draw()
        {
            System.Console.WriteLine($"Draw dot x:{_x} y:{_y}");
        }

        public void move(int x, int y)
        {
            this._x = x;
            this._y = y;
        }
    }
}
