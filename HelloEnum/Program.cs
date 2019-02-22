using System;

namespace HelloEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Skill = Skill.Drive | Skill.Program | Skill.Teach | Skill.Cook;
            System.Console.WriteLine((person.Skill & Skill.Cook) == Skill.Cook);
        }
    }
    class Person
    {
        public Skill Skill { get; set; }
    }
    enum Skill
    {
        Drive = 1,
        Cook = 2,
        Program = 4,
        Teach = 8,
    }
}
