using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Game.Liskov_Substitution_Principle
{
    public abstract class Shape
    {
       protected int height;
       protected int width;

       public abstract int GetArea();
    }

    class Rectangle : Shape
    {
        public void SetHeight(int height)
        {
            this.height = height;
        }
        public void SetWidth(int width)
        {
            this.width = width;
        }

        public override int GetArea()
        {
            return width * height;
        }
    }

    class Square : Shape
    {
        public void SetSide(int side)
        {
            width = side;
            height = side;
        }

        public override int GetArea()
        {
            return width * height;
        }
    }
}
