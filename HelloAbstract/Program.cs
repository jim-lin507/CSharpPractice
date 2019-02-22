using System;

namespace HelloAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new RaceCar();
            vehicle.Run();
        }
    }

    abstract class Vehicle
    {
        private int flag = 1;
        public void Stop()
        {
            System.Console.WriteLine("Stopped");
        }
        public void Fill()
        {
            System.Console.WriteLine("Filled");
        }
        public abstract void Run();
    }
    class Car : Vehicle
    {

        public override void Run()
        {
            System.Console.WriteLine("Car is running");
        }
    }
    class Truck : Vehicle
    {
        public override void Run()
        {
            System.Console.WriteLine("Truck is running");
        }
    }
    class RaceCar : Vehicle
    {
        public override void Run()
        {
            System.Console.WriteLine("Race car is running");
        }
    }
}
