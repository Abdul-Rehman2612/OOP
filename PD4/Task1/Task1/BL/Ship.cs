using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class Ship
    {
        public string SerialNumber;
        public Angle Latitude=new Angle();
        public Angle Longitude = new Angle();
        public Ship() { }
        public Ship(string SerialNumber, int LatitudeDegree, float LatitudeMinute, char LatitudeDirection, int LongitudeDegree, float LongitudeMinute,char LongitudeDirection)
        {
            this.SerialNumber = SerialNumber;
            Latitude.degree = LatitudeDegree;
            Latitude.minutes = LatitudeMinute;
            Latitude.direction = LatitudeDirection;
            Longitude.degree = LongitudeDegree;
            Longitude.minutes = LongitudeMinute;
            Longitude.direction = LongitudeDirection;
        }
        public void ChangeShipPosition(Angle Latitude, Angle Longitude)
        {
            this.Latitude.degree=Latitude.degree;
            this.Latitude.minutes=Latitude.minutes;
            this.Latitude.direction=Latitude.direction;
            this.Longitude.degree=Longitude.degree;
            this.Longitude.minutes=Longitude.minutes;
            this.Longitude.direction=Longitude.direction;
        }
    }
}