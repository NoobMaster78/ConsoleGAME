using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame
{
    class Character
    {
       private int health = 100;
       private int x = 50;
        private int y = 25;
        public int Health
        {
            get => health;
            set => health = value;
        }
        public int X => x;
        public int Y => y;
        public string Coordinates => $"[{x},{y}]";
        public bool IsAlive => health > 0;


    }
}
