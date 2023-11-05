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
            VideoPost videoPost1 = new VideoPost("FailVideo","Pham Tuan Anh", "http://video/shoes",true,10);
            Console.WriteLine(imagePost1.ToString());
            Console.WriteLine(videoPost1.ToString());
            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video");
            Console.ReadKey();
            videoPost1.Stop();
            
        }
    }


}


