using System;
using System.Collections.Generic;
using System.Linq;

namespace AggregationOperatorExample
{
    public class Program
    {
        public static void Main()
        {
            IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
            new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            new Student() { StudentID = 4, StudentName = "Willian" , Age = 20 } ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
        };
            var avgAge = studentList.Average(s => s.Age);
            Console.WriteLine($"Average Age of student:{avgAge}");

            var totalStudents = studentList.Count();
            Console.WriteLine($"Total Students:{totalStudents}");

            var adultStudents = studentList.Count(s => s.Age >= 18);
            Console.WriteLine($"Number of Adult Students:{adultStudents}");

            var totalAge = (from s in studentList
                            select s.Age).Count();
            Console.WriteLine($"Total Age:{totalAge}");

            var oldest = studentList.Max(s =>
            {
                if (s.Age % 2 == 0)
                    return s.Age;
                return 0;
            });
            Console.WriteLine($"Oldest Student Age:{oldest}");

            var studentWithLongName = studentList.Max();
            Console.WriteLine($"Student ID:{studentWithLongName.StudentID},Student Name:{studentWithLongName.StudentName}");

            var sumOfAge = studentList.Sum(s => s.Age);
            Console.WriteLine($"Sum of all student's age:{sumOfAge}");

            var numOfAdults = studentList.Sum(s =>
              {
                  if (s.Age >= 18)
                      return 1;
                  return 0;
              });
            Console.WriteLine($"Total Adult Students:{numOfAdults}");

            string[] stringArray = { "One", "Two" };
            Console.WriteLine($"1st Element in stringArray:{stringArray.ElementAt(0)}");

            IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four" };
            IList<string> strList2 = new List<string>() { "One", "Two", "Three", "Four" };

            bool isEqual = strList1.SequenceEqual(strList2);
            Console.WriteLine(isEqual);

            var strList3 = strList1.Concat(strList2);
            foreach (var str in strList3)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
        }
    }

    public class Student : IComparable<Student>
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

        public int CompareTo(Student other)
        {
            if (this.StudentName.Length >= other.StudentName.Length)
                return 1;
            return 0;
        }
    }
}
