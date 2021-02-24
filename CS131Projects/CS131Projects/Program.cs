using System;
using CS131Projects.DTOClasses;
using CS131Projects.MyClasses;


namespace CS131Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int x = 1; x < 21; x++)
            {
                sum += x;
            }


            Console.WriteLine("The sum of this loop is:" + sum);
        }
    }
}


