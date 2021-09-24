using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoGame
{
    public static class Dice
    {
        public static int Roll()
        {
            Random random = new Random(DateTime.Now.Millisecond);

            return random.Next(1, 6);
        }
    }
}
