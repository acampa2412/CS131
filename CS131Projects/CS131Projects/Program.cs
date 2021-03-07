using System;
using System.Collections.Generic;
using CS131Projects.DTOClasses;
using CS131Projects.MyClasses;


namespace CS131Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = new string[10] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            List<string> basketballTeams = new List<string>();
            basketballTeams.Add("Miami Heat");
            basketballTeams.Add("Los Angeles Lakers");
            basketballTeams.Add("Brooklyn Nets");
            basketballTeams.Add("Orlando Magic");
            basketballTeams.Add("Dallas Mavericks");
            basketballTeams.Add("New York Knicks");
            basketballTeams.Add("Phoenix Suns");
            basketballTeams.Add("Atlanta Hawks");
            basketballTeams.Add("Portland Trailblazers");
            basketballTeams.Add("Boston Celtics");



            foreach (var item in basketballTeams)
                Console.WriteLine(item + ", ");
        }
    }
}


