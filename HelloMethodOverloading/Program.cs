using System;

namespace HelloMethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(1, 2, 3, 4);
            int result2 = calculator.Add(new int[] { 1, 2, 8, 4 });
            System.Console.WriteLine("Sum=" + result);
            System.Console.WriteLine("Sum=" + result2);
        }
        static void UserPoint()
        {
            try
            {
                Point point = new Point(10, 20);
                point.Move(null);
                System.Console.WriteLine($"Point is at {point.x},{point.y}");
            }
            catch (Exception)
            {
                System.Console.WriteLine("An unexpected error occured");
            }
        }
    }
}
