using System;

namespace HelloGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple { Color = "Red" };
            Book book = new Book { Name = "Alchemist" };
            Box<Apple> box1 = new Box<Apple> { Cargo = apple };
            System.Console.WriteLine(box1.Cargo.Color);

            Box<Book> box2 = new Box<Book> { Cargo = book };
            System.Console.WriteLine(box2.Cargo.Name);

        }
    }

    class Apple
    {
        public string Color { get; set; }
    }
    class Book
    {
        public string Name { get; set; }
    }
    class Box<TCargo>
    {
        public TCargo Cargo { get; set; }
    }
}
