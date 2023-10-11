using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Bullet
{
    internal class Bullet
    {
        private int x;
        private int y;
        private string shape;

        public int X
        {
            set { x = value; }
        }

        public int Y
        {
            set { y = value; }
        }

        public string Shape
        {
            get { return shape; }
        }    
    }
}
