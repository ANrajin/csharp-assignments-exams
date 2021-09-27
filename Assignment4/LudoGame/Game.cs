using System;
using System.Collections.Generic;
using System.Text;
using LudoGame.Players;

namespace LudoGame
{
    public class Game:IGame
    {
        private bool _exit;

        private string _currentPlayer;

        public List<Player> Players { get; private set; }

        public Game()
        {
            Players = new List<Player>()
            {
                new RedPlayer(),
                new GreenPlayer(),
                new BluePlayer(),
                new YellowPlayer()
            };
            _exit = false;
        }

        public void Start(int n)
        {

            while (!_exit)
            {
                for (var i = 0; i < n; i++)
                {
                    Console.ForegroundColor = Players[i].Color;

                    ChangeTurn(i);

                    if (Players[i]._win)
                    {
                        _currentPlayer = Players[i].Name;
                        _exit = !_exit;
                        Exit();
                        return;
                    }
                }
            }
        }

        private void ChangeTurn(int i)
        {
            var number = Players[i].RollDice();

            if (number == 6)
                number = Players[i].RollDice();

            Console.WriteLine($"{Players[i].Name} rolled: {number}");

            int piece = GetPiece(i);

            Players[i].MovePiece(piece, number);
        }

        private int GetPiece(int i)
        {
            StringBuilder getPiece = new StringBuilder("Which piece to move? ");

            foreach (var p in Players[i]._piece)
            {
                getPiece.Append($"{p.Key}: {p.Value}, ");
            }

            Console.WriteLine(getPiece);

            return int.Parse(Console.ReadLine());
        }

        private void Exit()
        {
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine($"{_currentPlayer} wins!");
        }
    }
}
