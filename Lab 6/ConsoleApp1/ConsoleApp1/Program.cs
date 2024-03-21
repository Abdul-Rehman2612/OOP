using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Engine
    {
        public string engineType;
        public Engine(string type) {
        engineType = type;
        }
    }
    class Car
    {
        public Engine engine;
        public Car(Engine engine)
        {
            this.engine=engine;
        }
        public void CrushCar()
        {
            Console.WriteLine("Car crushed , including the engine ({0})",engine.engineType);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine("V8");
            Car car=new Car(engine);
            car.CrushCar();
            Console.ReadKey();
        }
    }
}
