using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoGame.Players
{
    interface IPlayer
    {
        public int RollDice();
        public void MovePiece(int index, int dice);
    }
}
