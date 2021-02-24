using System;
using CS131Projects.DTOClasses;
using CS131Projects.MyClasses;


namespace CS131Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myDateTimeVariable = new DateTime(2021, 2, 28);
            DateTime myDateTimeVariable2 = new DateTime(2021, 5, 26);

            int result = DateTime.Compare(myDateTimeVariable, myDateTimeVariable2);

            if (result == 1)
            {
                Console.WriteLine("This date comes first " + myDateTimeVariable);
            }
            else
            {
                Console.WriteLine("This date comes first " + myDateTimeVariable2);
            }
        }
    }
}


