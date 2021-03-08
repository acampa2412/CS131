using System;
using System.Collections.Generic;
using System.Linq;
using CS131Projects.DTOClasses;
using CS131Projects.MyClasses;


namespace CS131Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseballTeams<string> MLBTeams = new BaseballTeams<string>();
            MLBTeams.Team = "New York Yankees";
            MLBTeams.Team2 = "Los Angeles Dodgers";
            MLBTeams.Team3 = "San Diego Padres";

            List<string> TeamNames = new List<string>();

            TeamNames.Add(MLBTeams.Team);
            TeamNames.Add(MLBTeams.Team2);
            TeamNames.Add(MLBTeams.Team3);
            foreach (var result in TeamNames)
            {
                Console.WriteLine(result);
            }
            

            
        }
    }
}

public class BaseballTeams<B>
{
    public B Team { get; set; }
    public B Team2 { get; set; }
    public B Team3 { get; set; }
}