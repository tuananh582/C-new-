using System;
using System.Collections;
namespace hastable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            Student studi1 = new Student(1, "Maria", 76);
            Student studi2 = new Student(2, "Jhon", 36);
            Student studi3 = new Student(3, "Shaw", 46);
            Student studi4 = new Student(4, "Filler", 66);
            Student studi5 = new Student(5, "Sarah", 16);

            studentsTable.Add(studi1.Id, studi1);
            studentsTable.Add(studi2.Id, studi2);
            studentsTable.Add(studi3.Id, studi3);
            studentsTable.Add(studi4.Id, studi4);
            studentsTable.Add(studi5.Id, studi5);

            Student storeStudent1 = (Student) studentsTable[studi1.Id]; //cast
            foreach (DictionaryEntry entry in studentsTable )
            {
                Student temp =(Student) entry.Value;
                Console.WriteLine("Student ID:{0}, Name:{1}, GPA:{2}", temp.Id, temp.Name, temp.GPA);


            }

            //As the same above
            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine("Student ID:{0}, Name:{1}, GPA:{2}", value.Id, value.Name, value.GPA);

            }


            Console.WriteLine("///////////");
            Console.WriteLine("Student ID:{0}, Name:{1}, GPA:{2}",storeStudent1.Id,storeStudent1.Name,storeStudent1.GPA);
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }
        public Student(int id,string name,float GPA)
        {
            this.Id= id;
            this.Name = name;
            this.GPA = GPA;

        }
    }
}



