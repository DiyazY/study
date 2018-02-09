using System;
using composite.models;

namespace composite
{
    class Program
    {
        static void Main(string[] args)
        {   System.Console.WriteLine($"dot-begin");
            IGraphic dot = new Dot(1,1);
            dot.draw();
            dot.move(5,5);
            dot.draw();
            System.Console.WriteLine($"dot-end");

            System.Console.WriteLine($"rectangle-begin");
            IGraphic rectangle = new Rectangle(1,1,4,4);
            rectangle.draw();
            rectangle.move(10,17);
            rectangle.draw();
            System.Console.WriteLine($"rectangle-end {Environment.NewLine} ");

            System.Console.WriteLine($"circle-begin");
            IGraphic circle = new Circle(1,1,8);
            circle.draw();
            circle.move(10,4);
            circle.draw();
            System.Console.WriteLine($"circle-end {Environment.NewLine}");

            System.Console.WriteLine($"CompoundGraphic-begin");
            var component = new CompoundGraphic();
            component.draw();
            component.addChild(dot);
            component.addChild(circle);
            component.addChild(rectangle);
            component.draw();
            component.move(50,50);
            component.draw();
            System.Console.WriteLine($"CompoundGraphic-end {Environment.NewLine}");

            System.Console.WriteLine($"uicomponent-begin");
            var uicomponent = new CompoundGraphic();
            component.addChild(new Dot(3,5));
            component.addChild(new Circle(4,4,6));
            uicomponent.draw();
            System.Console.WriteLine($"uicomponent-end {Environment.NewLine}");

            System.Console.WriteLine($"mix-begin");
            component.addChild(uicomponent);
            component.draw();
            System.Console.WriteLine($"mix-end");
        }
    }
}
