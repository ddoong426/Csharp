using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Bullet
{
    internal class Movement
    {
        public int x;
        public int y;

        public void Move(int x, int y, string shape)
        {
            Console.SetCursorPosition(x,y);
        }

    }
}
