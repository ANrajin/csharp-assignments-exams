using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoGame
{
    public class Dice
    {
        public int Roll()
        {
            Random random = new Random(DateTime.Now.Millisecond);

            return random.Next(1, 6);
        }
    }
}
