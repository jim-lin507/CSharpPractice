using System;
using System.Collections.Generic;

namespace HelloLSP
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<IEmployee> employees = new List<IEmployee>();
            // employees.Add(new PermanentEmployee(1, "John"));
            // employees.Add(new TemporaryEmployee(2, "Tom"));
            // employees.Add(new ContractEmployee(3, "Mick"));
            // foreach (var employee in employees)
            // {
            //     System.Console.WriteLine(employee.GetMinimumSalary());
            // }
            IEmployee employee = new TemporaryEmployee(1, "John");
            System.Console.WriteLine("Salary:" + employee.GetMinimumSalary());
        }
    }
}
