using System;
namespace InheritanceChallenge2
{
	public class Employee
	{
		protected string Name { get; set; }
		protected string FirstName { get; set; }
		protected int Salary { get; set; }
		public Employee() { }
		public Employee(string name,string firstName,int salary)
		{
			this.Name = name;
			this.FirstName = firstName;
			this.Salary = salary;
		}
		public void Work()
		{
			Console.WriteLine("Im Working");
		}
		public void Pause()
		{
			Console.WriteLine("Im having a break");
		}
		
	}
}

