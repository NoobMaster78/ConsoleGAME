using System;

namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Character hero = new Character();
            Console.WriteLine($"Hero's health: {hero.Health} | Hero is alive: {hero.IsAlive}");
            hero.Health = 0;
            Console.WriteLine($"Hero's health: {hero.Health} | Hero is alive: {hero.IsAlive}");
            Console.WriteLine(hero.Coordinates);
        }
    }
}
