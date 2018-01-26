using System;
using System.Collections.Generic;
using visitor.models;

namespace visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var exportVisitors = new XMLExportVisitor();

            List<IShape> shapes = new List<IShape>(){
                new Rectangle(2,5),
                new Circle(),
                new Dot()
            };
            foreach(var shape in shapes){
                shape.Accept(exportVisitors);
            }
        }
    }
}
