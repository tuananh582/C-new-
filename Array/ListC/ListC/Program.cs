using System;
using System.Collections.Generic;
namespace ListC
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = new List<string>()
                             {
                                "California",
                                "London",
                                "English",
                                "Germany"
                             };
            name.Add("Dortmund");
            name.Add("America");
            name.Add("new York");
            name.Add("Ben city");
            name.Insert(2, "Tuan Anh");
         


            foreach (var city in name)
            {
                Console.WriteLine(city);
            }


        }
    }

}


