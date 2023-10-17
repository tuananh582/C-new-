using System;
namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] grades = new int[5];
            //int[] gradesofMathStudentA = { 20, 11, 12, 8, 8 };
            //Console.WriteLine("The length of it is {0}",gradesofMathStudentA.Length);
            //Console.ReadKey();
            int[] nums = new int[10];
            for(int i = 0; i < 10; i++)
            {
                nums[i] = i+10;
            }
            for(int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Element {0} = {1}", j, nums[j]);
            }
            int counter = 0;
            foreach(int k in nums)
            {
                Console.WriteLine("Element {0} = {1}", counter, k);
                counter++;

            }
            string[] name = { "sarah", "david", "lucas", "Micheal", "Kevin" };
            foreach(string s in name)
            {
                Console.WriteLine(s);
            }



            Console.ReadKey();

        }
    }
}



