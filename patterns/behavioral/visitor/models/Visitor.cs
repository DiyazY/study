using System;

namespace visitor.models
{
    interface IVisitor
    {
        void visit(Dot dot);
        void visit(Circle circle);
        void visit(Rectangle rectangle);
    }


    class XMLExportVisitor : IVisitor
    {
        public void visit(Dot dot)
        {
            System.Console.WriteLine($"Dot is exported to XML");
        }

        public void visit(Circle circle)
        {
            System.Console.WriteLine($"Circle is exported to XML");
        }

        public void visit(Rectangle rectangle)
        {
            System.Console.WriteLine($"Rectangle is exported to XML with perimetr {rectangle.Perimentr()}");
        }
    }
}
