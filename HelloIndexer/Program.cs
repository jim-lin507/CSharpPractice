using System;

namespace HelloIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloCookie helloCookie = new HelloCookie();
            helloCookie["name"] = "Jim";
            System.Console.WriteLine(helloCookie["name"]);
        }
    }
}
