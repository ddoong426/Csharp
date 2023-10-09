using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Inventory
{
    public delegate void Function();
    internal class Cursor
    {
        private int x;
        private int y;
        public Function function;

        ConsoleKeyInfo consoleKey;

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }
        public Cursor()
        {
            x = 0;
            y = 9;
        }

        public void Input()
        {
            Console.SetCursorPosition(x, y);

            Console.Write("△");

            consoleKey = Console.ReadKey();

            switch (consoleKey.Key)
            {
                case ConsoleKey.LeftArrow:
                    if (x > 0)
                    {
                        x -= 2;
                    }
                    else
                    {
                        x += 8;
                    }
                    break;


                case ConsoleKey.RightArrow:
                    if (x < 8)
                    {
                        x += 2;
                    }
                    else
                    {
                        x -= 8;
                    }
                    break;

                case ConsoleKey.UpArrow:
                    if (y > 9)
                    {
                        y -= 2;
                    }
                    else
                    {
                        y += 4;
                    }
                    break;

                case ConsoleKey.DownArrow:
                    if (y < 13)
                    {
                        y += 2;
                    }
                    else
                    {
                        y -= 4;
                    }
                    break;
                case ConsoleKey.Spacebar:
                    function();
                    break;
            }
        }

        bool VerticalOverFlow() // y축 (미구현)
        {
            return true;
        }

        bool HorizontalOverFlow() // x 축 (미구현)
        {
            if(y > 0 && y <= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
