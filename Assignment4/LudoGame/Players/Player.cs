using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoGame.Players
{
    public class Player:IPlayer
    {
        public bool _win = false;
        public const int _board = 250;

        public IDictionary<int, int> _piece;
        public string Name { get; set; }

        public ConsoleColor Color { get; protected set; }

        public Player()
        {
            _piece = new Dictionary<int, int>()
            {
                { 1, 0 },
                { 2, 0 },
                { 3, 0 },
                { 4, 0 }
            };
        }

        public void MovePiece(int index, int dice)
        {
            _piece[index] += dice;

            if (_piece[index] >= _board && _piece.ContainsKey(index))
                _piece.Remove(index);

            if (_piece.Count == 0)
                _win = true;

        }

        public int RollDice()
        {
            Dice dice = new Dice();
            return dice.Roll();
        }
    }
}
