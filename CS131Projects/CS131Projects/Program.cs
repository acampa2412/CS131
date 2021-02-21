using System;
using CS131Projects.MyClasses;


namespace CS131Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            Comments MyComment = new Comments();
            MyComment.FirstComment = "This is my first comment";
            

            Console.WriteLine(MyComment.FirstComment);
        }
    }
}


