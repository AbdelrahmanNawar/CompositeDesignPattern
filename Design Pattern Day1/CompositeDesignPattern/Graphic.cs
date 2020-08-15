using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDesignPattern
{
    abstract class Graphic
    {
        public virtual void Move(int x, int y) { }
        public virtual void Draw() { }
    }
}
