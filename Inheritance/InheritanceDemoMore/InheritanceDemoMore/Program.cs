using System;
namespace InheritanceDemoMore
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birhtday wishes", true, "Pham Tuan Anh");
            Console.WriteLine(post1.ToString());
            ImagePost imagePost1 = new ImagePost("check out my new shoes", true, "http://localhost/shoes", "Pham Tuan Anh");
            Console.WriteLine(imagePost1.ToString());
        }
    }


}


