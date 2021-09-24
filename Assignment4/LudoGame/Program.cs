using System;

namespace LudoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Many Players?");

            int n = int.Parse(Console.ReadLine());

            if (n < 2 || n > 4)
            {
                Console.WriteLine("There should be atleast 2-4 players");
                Environment.Exit(1);
            }

            LudoGame game = new LudoGame();

            for (var i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter player-0{i + 1} name & piece color");
                string name = Console.ReadLine();
                string color = Console.ReadLine();

                game.AddPlayer(new Player() { Name = name, Color = color });
            }

            game.Start(n);
        }
    }
}
