using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardQueryOperatorsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========Tuple==========");

            Tuple<int, string, string> person = new Tuple<int, string, string>(1, "Jim", "Lin");

            Console.WriteLine(person.Item1);
            Console.WriteLine(person.Item2);
            Console.WriteLine(person.Item3);


            var numbers = Tuple.Create("One", 2, 3, "Four", 5, "Six", 7, 8);

            Console.WriteLine(numbers.Item1); // returns "One"
            Console.WriteLine(numbers.Item2); // returns 2
            Console.WriteLine(numbers.Item3); // returns 3
            Console.WriteLine(numbers.Item4); // returns "Four"
            Console.WriteLine(numbers.Item5); // returns 5
            Console.WriteLine(numbers.Item6); // returns "Six"
            Console.WriteLine(numbers.Item7); // returns 7
            Console.WriteLine(numbers.Rest); // returns (8)
            Console.WriteLine(numbers.Rest.Item1); // returns 8

            // Student collection
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 25 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 28 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };


            Console.WriteLine("=========SingleOrDefault==========");
            Student single=new Student();
            try
            {
                single= studentList.SingleOrDefault(s => s.Age == 18);
                Console.WriteLine("Student name:"+single.StudentName);
            }
            catch (Exception e)
            {

                Console.WriteLine("Something wrong");

            }


            //var multiSortingResult = from s in studentList
            //                         orderby s.StudentName, s.Age
            //                         select s;

            var multiSortingResult = studentList.OrderBy(s => s.StudentName).ThenBy(s => s.Age);
            Console.WriteLine("=========Multiple Sorting==========");

            foreach (var std in multiSortingResult)
                Console.WriteLine("Name: {0}, Age {1}", std.StudentName, std.Age);


            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            mixedList.Add(new Student {StudentID=1,StudentName="Bill" });

            //var stringResult = from s in mixedList.OfType<string>()
            //                   select s;

            var stringResult = mixedList.OfType<string>();

            Console.WriteLine("=========Filtering Operator - OfType==========");
            foreach (var str in stringResult)
                Console.WriteLine(str);

            //var groupResult = from s in studentList
            //                  group s by s.Age;

            var groupResult = studentList.GroupBy(s => s.Age).SelectMany((s,index)=>s.Select(a=>a.Age));
            var lookUpResult = studentList.ToLookup(s => s.Age);

            foreach (var age in groupResult)
            {
                Console.WriteLine(age);
            }

            //Console.WriteLine("=========GroupBy==========");
            //foreach (var ageGroup in groupResult)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine($"Age Group:{ageGroup}");

            //    Console.ForegroundColor = ConsoleColor.Green;
            //    foreach (Student s in ageGroup)
            //        Console.WriteLine($"Student Name:{s.StudentName}");

            //}

        }
    }
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }

}
