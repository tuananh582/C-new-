using System;
namespace InheritanceChallenge2
{
	public class Boss:Employee
	{
		public string CompanyCar { get; set; }
		public Boss(string companyCar, string name, string firstName,int salary):base(name,firstName,salary)
		{
			this.CompanyCar = companyCar;
		}


		public void Lead()
		{
			Console.WriteLine("Im boss!");
		}
	}
}

