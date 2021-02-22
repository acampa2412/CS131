using System;
using CS131Projects.DTOClasses;
using CS131Projects.MyClasses;


namespace CS131Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            UsersDTO username = new UsersDTO();
            username.userID = 2;
            username.user = "Anthony Campa";

            Console.WriteLine("I am user number " + username.userID);
            Console.WriteLine("My name is " + username.user);
        }
    }
}


