using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDesignPattern
{
    class Circle : Dot
    {
        public double Radius { get; set; }

        public Circle(int x, int y, double radius)
            : base(x, y)
        {
            Radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }
}
