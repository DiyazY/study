using System;

namespace visitor.models
{
    interface IShape
    {
        void move(int x, int y);
        void draw();
        void Accept(IVisitor visitor);
    }
    class Rectangle : IShape
    {
        private int _a { get; set; }  
        private int _b { get; set; }
        public Rectangle(int a, int b){
            _a=a;
            _b=b;
        }
        public double Perimentr(){
            return _a*_b;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.visit(this);
        }

        public void draw()
        {
            throw new NotImplementedException();
        }

        public void move(int x, int y)
        {
            throw new NotImplementedException();
        }
    }

    class Dot : IShape
    {
        public void Accept(IVisitor visitor)
        {
            visitor.visit(this);
        }

        public void draw()
        {
            throw new NotImplementedException();
        }

        public void move(int x, int y)
        {
            throw new NotImplementedException();
        }
    }

    class Circle : IShape
    {
        public void Accept(IVisitor visitor)
        {
            visitor.visit(this);
        }

        public void draw()
        {
            throw new NotImplementedException();
        }

        public void move(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
