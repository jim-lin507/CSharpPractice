using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student collection
            IList<Student> studentList = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };

            //LINQ Query syntax to find out tennager students
            var teenagerStudents = from s in studentList
                                   where IsTeenager(s)
                                   select new
                                   {
                                       s.StudentID,
                                       s.StudentName
                                   };

            //LINQ Method syntax to find out tennager students
            //var teenagerStudents = studentList.Where(s => s.Age > 12 && s.Age < 20).Select(s => new { s.StudentID, s.StudentName }).ToList();
            var students=studentList.Where((s, i) =>
            {
                if (s.StudentID%2==0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }).Where(s=>s.StudentID>2);
            Console.WriteLine("Teenager students:");

            foreach (var student in teenagerStudents)
            {
                Console.WriteLine($"StudentID:{student.StudentID},StudentName:{student.StudentName}");
            }

            //string collection
            IList<string> stringList = new List<string>()
            {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials" ,
                "Java"
            };

            //LINQ Query Syntax
            //var result = from s in stringList
            //             where s.Contains("Tutorials")
            //             select s;

            //LINQ Method Syntax
            var result = stringList.Where(s => s.Contains("Tutorials"));
            foreach (var str in result)
            {
                Console.WriteLine(str);
            }
        }
        static bool IsTeenager(Student student)
        {
            return student.Age > 12 && student.Age < 20;
        }
    }
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
}
