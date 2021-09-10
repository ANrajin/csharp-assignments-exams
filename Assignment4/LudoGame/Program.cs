using LudoGame.Players;
using System;
using System.Collections.Generic;

namespace LudoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Many Players?");
            int n = Convert.ToInt32(Console.ReadLine());

            List<Player> player = new List<Player>();

            string[] colors = new string[]
            {
                "Red",
                "Green",
                "Blue",
                "Yellow"
            };

            for (var i = 1;  i <= n; i++)
            {
                Console.WriteLine($"Enter player{i} name:");

                var name = Console.ReadLine();
                player.Add(new Player(name, colors[i-1]));
            }
        }
    }
}
