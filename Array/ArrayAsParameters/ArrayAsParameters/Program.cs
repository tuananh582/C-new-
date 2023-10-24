using System;
namespace ArrayAsParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentGrades = new int[] { 15, 13, 8, 12, 6, 16 };
            double averageResult = GetAverage(studentGrades);
            foreach(int grade in studentGrades)
            {
                Console.WriteLine("{0}",grade);
            }
            Console.WriteLine("The average is :{0}",averageResult);
            Console.WriteLine("///////////////////");

            //int min = MinV2(6, 4, 2, 7, 8, 0, 1, 5);
            int min = MinV2(6, 4,0,-11,40 );
            Console.WriteLine("The minium is {0}",min);
            Console.ReadKey();


        }
        static double GetAverage(int[] gradeArray)
        {
            int size = gradeArray.Length;
            double average;
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += gradeArray[i];
            }
            average =(double) sum / size;
            return average;
        }
        public static int MinV2(params int[] numbers)
        {
            int min = int.MaxValue;
            foreach(int number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            return min;
        }
    }


}

