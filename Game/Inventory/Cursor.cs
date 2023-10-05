using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Inventory
{
    internal class Cursor
    {
        int x;
        int y;

        ConsoleKeyInfo consoleKey;

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

                case ConsoleKey.Q:
                    return;
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
