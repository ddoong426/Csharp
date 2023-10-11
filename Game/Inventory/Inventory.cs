using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Inventory
{
    internal class Inventory
    {
        uint lineX;
        private Item[] items;
        int select;

        public Inventory(uint x,uint y)
        {
            lineX = x;
            items = new Item[x * y];
        }

        public void AddItem(Item item) 
        {
            for(int i = 0; i < items.Length; i++)
            {
                if (items[i] == null)
                {
                    items[i] = item;
                    break;
                }

                if(i == items.Length - 1) 
                {
                    Console.WriteLine("인벤토리가 가득 찼습니다.");
                }
            }
        }

        public void SelectNumber(Cursor cursor)
        {
            int resultX = cursor.X / 2;
            int resultY = cursor.Y / 2 * (int)lineX;

            select = resultX + resultY - 20;
        }

        public void ShowItem()
        {
            if (items[select] != null)
            {
                items[select].Information();
            }
            else 
            {
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("비어 있음.");
            }
        }

        public void RemoveItem()
        {
            if (items[select] != null)
            {
                items[select] = null;
            }
        }

        public void Rendere()
        {
            for (int i = 0; i < items.Length; i++) 
            {
                if(i % lineX == 0) 
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                }
                if (items[i] == null) 
                {
                    Console.Write("□ ");
                }
                else if (items[i]!=null) 
                {
                    Console.Write("■ ");
                }
            }
        }

    }

}
