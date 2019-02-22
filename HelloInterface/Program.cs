using System;

namespace HelloInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle vehicle = new Car();
            vehicle.Run();
        }
    }

    interface IVehicle
    {
        void Stop();
        void Fill();
        void Run();
    }
    class Car : IVehicle
    {
        public void Stop()
        {
            System.Console.WriteLine("Stopped");
        }
        public void Fill()
        {
            System.Console.WriteLine("Filled");
        }
        public void Run()
        {
            System.Console.WriteLine("Car is running");
        }
    }
    class Truck : IVehicle
    {
        public void Stop()
        {
            System.Console.WriteLine("Stopped");
        }
        public void Fill()
        {
            System.Console.WriteLine("Filled");
        }
        public void Run()
        {
            System.Console.WriteLine("Truck is running");
        }
    }
}
