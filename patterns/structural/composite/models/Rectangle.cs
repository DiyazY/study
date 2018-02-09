using System;

namespace composite.models
{
    public class Rectangle : IGraphic
    {
        private int _x,_y,_width,_heigth;

        public Rectangle(int x, int y,int width, int heigth){
            this._x = x;
            this._y = y;
            this._heigth = heigth;
            this._width = width;
        }

        public void draw()
        {
            System.Console.WriteLine($"Draw rectangle dot x:{_x} y:{_y} with width:{_width} and heigth:{_heigth}");
        }

        public void move(int x, int y)
        {
            this._x = x;
            this._y = y;
        }
    }
}
