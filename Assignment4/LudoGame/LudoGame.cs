using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoGame
{
    public class LudoGame : IGame
    {
        private List<Player> _player;

        private bool _exit;

        private string _currentPlayer;

        public IReadOnlyCollection<Player> Player
        {
            get
            {
                return new ReadOnlyCollection<Player>(_player);
            }
        }

        public LudoGame()
        {
            _player = new List<Player>();
            _exit = false;
        }

        public void AddPlayer(Player player)
        {
            if(String.IsNullOrEmpty(player.Name) || string.IsNullOrEmpty(player.Color))
            {
                throw new InvalidOperationException("Player name or color is required!");
            }

            _player.Add(player);
        }

        public void Start(int n)
        {
            while (!_exit)
            {
                for(var i = 0; i < n; i++)
                {
                    if (_player[i]._win)
                    {
                        _currentPlayer = _player[i].Name;
                        _exit = !_exit;
                        break;
                    }
                    var number = _player[i].RollDice();
                    Console.WriteLine($"{_player[i].Name} rolled number: {number}");

                    StringBuilder getPiece = new StringBuilder("which piece to move? ");

                    foreach(var p in _player[i]._piece)
                    {
                        getPiece.Append($"{p.Key}: {p.Value}, ");
                    }

                    Console.WriteLine(getPiece);

                    int piece = int.Parse(Console.ReadLine());

                    _player[i].MovePiece(piece, number);

                    Console.WriteLine();
                    Console.WriteLine();
                }

                if (_exit)
                {
                    Console.WriteLine($"{_currentPlayer} wins!");
                    break;
                }
            }
        }
    }
}
