using System;

namespace HelloUpDowncasting
{
    class Text : Shape
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }
        public override void Draw()
        {
            System.Console.WriteLine("Draw a Text");
        }
    }
}