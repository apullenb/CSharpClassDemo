using System;

namespace CSharpClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thank You!", true, "Andrea");

            Post post2 = new Post("Second Post", true, "Andrea P");
            Console.WriteLine(post1.ToString());
            Console.WriteLine(post2.ToString());
           

            ImagePost imagePost1 = new ImagePost("New Shoes!", "Andrea P", "http://www.facebook.com", true);
            Console.WriteLine(imagePost1.ToString());
            Console.ReadLine();
        }
    }
}
