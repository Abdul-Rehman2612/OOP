using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Mountainbike : Bicycle
    {
        private int seatheight;
         public Mountainbike(int seatheight, int cadence, int gear, int speed):base(cadence, gear, speed)
        {
            this.seatheight = seatheight;
      

        }
        public void setseatheight(int height)
        {
            this.seatheight = height;
        }
        public int getseatheight(int height)
        {
            return this.seatheight;
        }
    }
}

