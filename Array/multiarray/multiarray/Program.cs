using System;
namespace multiarray
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare 2d arrays
            string[,] matrix;
            //declare 3d arrays
            string[,,] threed;
            int[,] array2D = new int[,]
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };
           

            string[,,] array3D = new string[,,]
            {
                {
                    { "000","001"},
                    { "010","011"},
                    {"Hi there","what'sup" }
                },
                {
                    {"100","101" },
                    {"110","111" },
                    {"Another one ","Last entry" }
                }
            };

            string[,] array2DString = new string[3, 2]
            {
                {"one","two" },
                {"three","four" },
                {"five","six" }
            };
            array2DString[1,1] = "chicken";
            foreach(string s in array2DString)
            {
                Console.WriteLine(s);
            }
            //Console.WriteLine("{0}",array2DString);
            Console.WriteLine("Center value is {0}", array3D[1, 2,0]);
            Console.ReadKey();
        }
    }

}


