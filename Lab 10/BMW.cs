using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    internal class BMW: Car
    {
        private string series;
        private string Smodel;
        private bool GestureControl;
        private bool LaserLight;
        public BMW(string series, string Smodel,string color,string model,int price,bool GestureControl,bool LaserLight): base(model,color,price)
        {
            this.series = series;
            this.Smodel=Smodel;
            this.GestureControl=GestureControl;
            this.LaserLight=LaserLight;
        }
        public string GetSeries() {  return series; }
        public string GetSmodel() {  return Smodel; }
        public void SetGesture() { if (GestureControl) GestureControl = false; else GestureControl=false; }
        public bool GetGesture() { return GestureControl; }
        public void SetLaserLight() { if (LaserLight) LaserLight = false; else LaserLight=true; }
        public bool GetLaserLight() {  return LaserLight; }
        public double CalculateConsumption(double distance)
        {
            return distance*0.8;
        }
    }
}
