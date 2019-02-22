using System;

namespace HelloStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student { ID = 101, Name = "Jim" };
            object obj = student;
            Student student2 = (Student)obj;
            // System.Console.WriteLine($"ID:{student2.ID}, Name:{student2.Name}");
            student.Speak();
        }
    }
    interface ISpeak
    {
        void Speak();
    }
    struct Student : ISpeak
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Student(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
        public void Speak()
        {
            System.Console.WriteLine($"Speaker is ID:{this.ID}, Name:{this.Name}");
        }

    }
}
