using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task(CallMethod);
            task.Start();
            task.Wait();
            Console.ReadLine();
        }
        static async void CallMethod()
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory+"note.txt";
            Task<int> task = ReadFile(filePath);

            Console.WriteLine("Other Work 1");
            Console.WriteLine("Other Work 2");
            Console.WriteLine("Other Work 3");

            int length = await task;
            Console.WriteLine("Total length:"+length);
            Console.WriteLine("After work 1");
            Console.WriteLine("After work 2");
        }
        static async Task<int> ReadFile(string filePath)
        {
            int length = 0;
            Console.WriteLine("File reading is starting");
            using (StreamReader reader = new StreamReader(filePath))
            {
                string s = await reader.ReadToEndAsync();
                length = s.Length;
            }
            Console.WriteLine("File reading is completed");
            return length;
        }
    }
}
