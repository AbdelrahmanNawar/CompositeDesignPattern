using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDesignPattern
{
    class CompoundGraphic : Graphic
    {
        public List<Graphic> Graphics { get; set; }

        public CompoundGraphic()
        {
            Graphics = new List<Graphic>();
        }

        public void Add (Graphic graphic)
        {
            Graphics.Add(graphic);
        }

        public void Remove (Graphic graphic)
        {
            Graphics.Remove(graphic);
        }

        public override void Move(int x, int y)
        {
            Console.WriteLine($"Compound graphic has been reallocated to (x: {x}, y: {y})");
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a compound graphic");
        }
    }
}
