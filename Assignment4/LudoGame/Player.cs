using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoGame
{
    public class Player:IPlayer
    {
        public bool _win = false;
        public const int _board = 200;
        public IDictionary<int, int> _piece;
        public string Name { get; set; }
        public string Color { get; set; }

        public Player()
        {
            _piece = new Dictionary<int, int>()
            {
                { 1, 0},
                { 2, 0},
            };
        }

        public int RollDice()
        {
            return Dice.Roll();
        }

        public void MovePiece(int index, int dice)
        {
            _piece[index] += dice;

            if (_piece[index] >= _board && _piece.ContainsKey(index))
                _piece.Remove(index);

            if (_piece.Count == 0)
                _win = true;
        }
    }
}
