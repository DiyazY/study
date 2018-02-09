using System;

namespace composite.models
{
    public class Circle : IGraphic
    {
        private int _x,_y,_radius;

        public Circle(int x, int y,int radius){
            this._x = x;
            this._y = y;
            this._radius = radius;
        }

        public void draw()
        {
            System.Console.WriteLine($"Draw circle x:{_x} y:{_y} with radius:{_radius}");
        }

        public void move(int x, int y)
        {
            this._x = x;
            this._y = y;
        }
    }
}
