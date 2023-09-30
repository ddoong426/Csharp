using Game.Interface_Segregation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Interface_Segregation
{
    public class Pistol : Igun
    {
        public void Launch()
        {
            Console.WriteLine("권총 발사");
        }

        public void Reload()
        {
            Console.WriteLine("권총 장전");
        }
    }

    public class Sniper : Igun, IScope
    {
        public void Launch()
        {
            Console.WriteLine("저격총 발사");
        }

        public void Reload()
        {
            Console.WriteLine("저격총 장전");
        }

        public void Zoom(float value)
        {
            Console.WriteLine("현재 확대 값 : " + value);
        }
    }

    public class Rifle : Igun
    {
        public void Launch()
        {
            Console.WriteLine("소총 발사");
        }

        public void Reload()
        {
            Console.WriteLine("소총 장전");
        }
    }
}


