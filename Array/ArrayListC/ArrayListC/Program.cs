using System;
using System.Collections;
namespace ArrayListC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Delcaring an ArrayList with undefined amount of object 
            ArrayList myarrayList = new ArrayList();
            ArrayList myarrayList2 = new ArrayList(100);
            myarrayList.Add(25);
            myarrayList.Add("Hello");
            myarrayList.Add(13.37);
            myarrayList.Add(13);
            myarrayList.Add(128);
            myarrayList.Add(25.3);
         
            //Delete
            myarrayList.Remove(13);
            //Delete the element at specific position
            myarrayList.RemoveAt(0);

            Console.WriteLine(myarrayList.Count);

            double sum = 0;
            foreach(object obj in myarrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += (double)obj;
                }
                else if (obj is string)
                {
                    Console.WriteLine(obj);
                }
                Console.WriteLine(obj);
            }
            Console.WriteLine(sum);
            Console.ReadKey();
           



        }
    }

}


