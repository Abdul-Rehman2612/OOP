using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    internal class MountainBike: Bicycle
    {
        private int seatHeight;
        public MountainBike(int seatHeight,int cadence,int speed,int gear): base(cadence,gear,speed)
        {
            this.seatHeight = seatHeight;
        }
        public void SetSeatHeight(int seatHeight) { this.seatHeight=seatHeight; }
        public int GetSeatHeight() {  return this.seatHeight; }
    }
}
