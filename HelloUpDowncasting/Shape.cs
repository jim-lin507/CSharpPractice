using System;

namespace HelloUpDowncasting
{
    class Shape
    {
        public int Width { get; set; }
        public int Weight { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public virtual void Draw()
        {
            System.Console.WriteLine("Draw a picture");
        }
    }
}