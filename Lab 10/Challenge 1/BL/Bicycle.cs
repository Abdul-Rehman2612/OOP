using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Bicycle
    {
       protected int cadence;
       protected int gear;
       protected int speed;
         
        public Bicycle(int cadence, int gear, int speed)
        {
            this.cadence = cadence;
            this.gear = gear;
            this.speed = speed;
        }
        public void setCadence(int cadence)
        {
            this . cadence = cadence;
        }

        public void setGear(int gear)
        {
            this.gear = gear;
        }
        public void setSpeed(int speed)
        {
            this.speed=speed;
        }
        public int getcadence()
        {
            return this.cadence;
        }
        public int getgear()
        {
            return this.gear;
        }
        public int getspeed()
        {
            return this.speed;
        }
        public void applybrake(int dec)
        {
            this.speed = speed - dec;
        }
        public void speedup(int inc)
        {
            this.speed = speed + inc;
        }
            
    }
}
