using System.Diagnostics.Contracts;
using System;

namespace Modellering
{
    class Program
    {
        static void Main(string[] args)
        {
            Player bobby = new Player();

            bobby.name = "Bobby";
            bobby.health = 100;
            bobby.inventory = 3;
            bobby.damage -= 5;

            Console.WriteLine($"Name: {bobby.name}");
            Console.WriteLine($"Health: {bobby.health}%");
            Console.WriteLine($"inventory: {bobby.inventory}");

            Console.ReadLine();
        }
    }
}
