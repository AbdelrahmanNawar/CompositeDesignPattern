using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDesignPattern
{
    class Dot : Graphic
    {
        int x;
        int y;
        public Dot()
        {

        }

        public Dot( int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a DOT");
        }

        public override void Move(int x, int y)
        {
            Console.WriteLine($"Dot has been reallocated to (x: {x}, y: {y})");
        }
    }
}
