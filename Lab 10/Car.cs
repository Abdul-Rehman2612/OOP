using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    internal class Car
    {
        protected string model;
        protected string color;
        protected int price;
        protected int FuelConsumption;
        public Car() { }
        public Car(string model, string color, int price)
        {
            this.model=model;
            this.color=color;
            this.price=price;
        }
        public void SetModel(string model) { this.model=model; }
        public string GetModel() { return this.model; }
        public void SetPrice(int price) {  this.price = price; }
        public int GetPrice() { return this.price; }
        public void SetColor(string color) {  this.color = color; }
        public string GetColor(string color) { return this.color; }
    }
}
