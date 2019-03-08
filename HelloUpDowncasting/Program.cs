using System;
using System.Collections;

namespace HelloUpDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();
            Shape shape = text;
            text.Draw();
            shape.Draw();

            text.Width = 200;
            shape.Width = 100;
            System.Console.WriteLine(text.Width);

            var list = new ArrayList();
            list.Add(1);
            list.Add("Jim");
            list.Add(new Text());


        }
    }
}
