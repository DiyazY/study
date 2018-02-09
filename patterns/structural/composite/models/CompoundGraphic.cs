using System;
using System.Collections.Generic;

namespace composite.models
{
    public class CompoundGraphic : IGraphic
    {
        private List<IGraphic> _children = new List<IGraphic>();

        public void addChild(IGraphic child){
            _children.Add(child);
        }

        public void removeChild(IGraphic child){
            _children.Remove(child);
        }

        public void draw()
        {
            foreach (var child in _children)
            {
                child.draw();
            }
        }

        public void move(int x, int y)
        {
            foreach (var child in _children)
            {
                child.move(x,y);
            }
        }
    }
}
