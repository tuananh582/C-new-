using System;
using System.Collections;
namespace hastableChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            Student[] students = new Student[5];
            students[0] = new Student(1, "Tuan Anh", 88);
            students[1] = new Student(2, "Tuan Anh", 98);
            students[2] = new Student(3, "Tuan Anh", 118);
            students[3] = new Student(4, "Tuan Anh", 128);
            students[4] = new Student(5, "Tuan Anh", 138);

            foreach (Student s in students)
            {
                if (!table.ContainsKey(s.Id))
                {
                    table.Add(s.Id, s);
                    Console.WriteLine($"Student with ID {s.Id} was added!");
                }
                else
                {
                    Console.WriteLine($"Sorry a student with the same ID already exitst ID {s.Id} ");
                }
            }



        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }
        public Student(int id,string name,float GPA)
        {
            //constructor
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;

        }

    }


}



