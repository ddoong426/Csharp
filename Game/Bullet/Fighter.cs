using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Bullet
{
    internal class Fighter
    {
        string shape;

        private int bulletCount;

        private Bullet [] bullet = new Bullet[5];

        public Fighter()
        {
            bulletCount = 5;
            bullet =new Bullet[bulletCount];
        }
    }
}
