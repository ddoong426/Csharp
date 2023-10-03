using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Unit
    {
        protected int hp;

        protected int attack;

        public virtual void Created()
        {
            Console.WriteLine("유닛 생성");
        }
    }

    public class Vulture : Unit
    {
        public override void Created()
        {
            Console.WriteLine("벌쳐 생성");
        }
    }

    public class SiegeTank : Unit
    {
        public override void Created()
        {
            Console.WriteLine("시즈탱크 생성");
        }
    }

    public class Goliath : Unit
    {
        public override void Created()
        {
            Console.WriteLine("골리앗 생성");
        }
    }


    internal class VirtualFunction
    {
        #region 가상 함수
        ConsoleKeyInfo consoleKey;

        Unit unit = null;

            while(true) 
            {
            
            consoleKey = Console.ReadKey(true);

                switch (consoleKey.Key)
                {
                    case ConsoleKey.Q: unit = new Vulture();
                        break;
                    case ConsoleKey.W: unit = new SiegeTank();
                        break;
                    case ConsoleKey.E: unit = new Goliath();
                        break;
                    default : unit = null;
                        break;
                }

                if (unit != null)
                {
                    unit.Created();
                }
                else
                {
                    Console.WriteLine("1");
                }

            }
            #endregion

    }
}
