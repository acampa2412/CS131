using System;
using CS131Projects.DTOClasses;
using CS131Projects.MyClasses;


namespace CS131Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };

            foreach (var item in myArray)
                Console.WriteLine(item);
        }
    }
}


