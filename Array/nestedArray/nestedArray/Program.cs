using System;
namespace nestedArray
{



    class Program
    {
        static int[,] matrix =
        {
        {1,2,3 },
        {4,5,6 },
        {7,8,9 },

        };
        static void Main(string[] args)
        {
            
            //Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine("This is our 2d array printed using nested for loop");
            //Console.WriteLine(matrix.GetLength(0));
            //Console.WriteLine("//////");
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                //inner for loop
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    //Console.Write(matrix[i,j]+"\t");
                    //if (matrix[i,j] % 2 == 0)
                    //{
                    //    Console.WriteLine(matrix[i,j]+"\t");
                    //}
                    if (i == j)
                    {
                        //Console.WriteLine(matrix[i,j]+" ");
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        Console.WriteLine(" ");
                    }
                }
            }
            Console.WriteLine();
            foreach (int item in matrix)
            {
                Console.Write(item +" ");
            }
            Console.WriteLine();
        }
    }

}







