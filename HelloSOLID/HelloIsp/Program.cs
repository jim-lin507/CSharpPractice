using System;

namespace HelloIsp
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver(new Tank());
            driver.Drive();
        }
    }
    class Driver
    {
        private IVehicle _vehicle;
        public Driver(IVehicle vehicle)
        {
            this._vehicle = vehicle;
        }
        public void Drive()
        {
            _vehicle.Run();
        }
    }
    interface IVehicle
    {
        void Run();
    }
    class Car : IVehicle
    {
        public void Run()
        {
            System.Console.WriteLine("Car is running");
        }
    }
    class Truck : IVehicle
    {
        public void Run()
        {
            System.Console.WriteLine("Truck is running");
        }
    }
    interface IWeapon
    {
        void Fire();
    }
    class Tank : IVehicle, IWeapon
    {
        public void Run()
        {
            System.Console.WriteLine("Tank is running");
        }
        public void Fire()
        {
            System.Console.WriteLine("Boom");
        }
    }
}
