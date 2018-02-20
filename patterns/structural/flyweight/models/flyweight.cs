using System;
using System.Collections.Generic;

namespace flyweight.models
{
    //Flyweight class
    public class TreeType
    {
        private readonly string _name;
        private readonly string _color;
        private readonly string _texture;

        public TreeType(string name, string color, string texture){
            _name = name;
            _color = color;
            _texture = texture;
        }

        public void Draw(string canvas, int x, int y){
            Console.WriteLine($@"Draw {_name}:
                color:{_color}
                texture:{_texture}
                canvas:{canvas}
                position:({x},{y})
            ");
        }

        public bool Equals(string name, string color, string texture)
        {
           return (_color == color && _name == name && texture == _texture);
        }
    }

    // Main class (Flyweight's client)
    public class Tree{
        private int _x{get;set;}
        private int _y{get;set;}
        private TreeType _type { get; set; }

        public Tree(int x,int y,TreeType type){
            _x = x;
            _y=y;
            _type = type;
        }

        public void Draw(string canvas){
            _type.Draw(canvas,_x,_y);
        }
    }

    // Flyweight factory
    public static class TreeFactory{
        private static List<TreeType> types = new List<TreeType>();
        public static TreeType GetTreeType(string name, string color, string texture){
            var type = types.Find(p=>p.Equals(name,color,texture));
            if(type == null){
                type = new TreeType(name,color,texture);
                types.Add(type);
            }
            
            Console.WriteLine($"types count: {types.Count}");
            return type;
        }
    }

    // Forest (Flyweight's client)
    public class Forest
    {
        private List<Tree> trees = new List<Tree>();

        public void plantTree(int x,int y,string name,string color, string texture){
            var type = TreeFactory.GetTreeType(name,color,texture);
            var tree = new Tree(x,y,type);
            trees.Add(tree);
        }

        public void Draw(string canvas){
            foreach (var tree in trees)
            {
                tree.Draw(canvas);
            }
        }
        
    }
}
