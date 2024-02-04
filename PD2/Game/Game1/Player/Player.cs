using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Player
{
    internal class Player
    {
        public char[,] player = new char[3, 3];
        public int pX;
        public int pY;
        public Player()
        {
            this.player = new char[3, 3]  {
            {'\\','o','/'},
            {'=','o','='},
            {'/','o','\\'},
        };
            pX=3;
            pY=10;
        }

    }
}
