﻿using Game.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory.Inventory inventory = new Inventory.Inventory(5, 3);

            inventory.AddItem(new Item(100, "포션"));
            inventory.AddItem(new Item(1000, "투구"));
            inventory.AddItem(new Item(750, "조합석"));


            Cursor cursor = new Cursor();

            while (true)
            {

                Console.Clear();

                Console.SetCursorPosition(0, 6);
                inventory.Rendere();

                cursor.Input();
            }
        }
    }
}