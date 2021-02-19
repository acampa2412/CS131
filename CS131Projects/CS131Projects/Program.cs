using System;

namespace CS131Projects
{
    class Program
    {
        static void Main(string[] args)
        {

            NBATeams East = new NBATeams();
            East.TeamName = "Miami Heat";
            

            Console.WriteLine("My favorite basketball team is the " + East.TeamName);
        }
    }
}

public class NBATeams
{
    public string TeamName { get; set; }
    
}
