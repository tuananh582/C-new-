using System;
using System.Collections.Generic;

namespace dictionarisDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees =
            {
                new Employee("Ceo","Gwyn",95,200),
                new Employee("Manager","Joe",35,25),
                new Employee("HR","Lora",25,300),
                new Employee("Secretary","Petra",15,100),
                new Employee("Lead","Artorias",45,140),
                new Employee("Intern","Ernest",55,130),
            };




            //Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            Dictionary<string, Employee> employeeDirectory = new Dictionary<string, Employee>();
            foreach(Employee emp in employees)
            {
                employeeDirectory.Add(emp.Role, emp);
                Console.WriteLine($"Employee Name:{emp.Name}, Role:{emp.Role},:Salary:{emp.Salary}");

            }
            Employee result = null;
            if(employeeDirectory.TryGetValue("Intern",out result))
            {
                Console.WriteLine("Value Retrived");
                Console.WriteLine($"Employee Name:{result.Name}");
                Console.WriteLine($"Employee Role:{result.Role}");
                Console.WriteLine($"Employee Age:{result.Age}");
                Console.WriteLine($"Employee Salary:{result.Salary}");
            }
            else
            {
                Console.WriteLine("The key does not exisit");
            }
            //Employee empl = employeeDirectory["Ceo"];

        }
    }
    class Employee
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }
        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }
        public Employee(string role, string name, int age, float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }



    }
}



