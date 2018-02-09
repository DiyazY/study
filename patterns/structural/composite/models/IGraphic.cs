using System;

namespace composite.models
{
    public interface IGraphic
    {
        void move(int x, int y);
        void draw();
    }
}
