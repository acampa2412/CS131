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
            List<Users> users = new List<Users>();
            
            Users user1 = new Users();
            user1.Name = "Anthony";
            user1.ID = 1;
            user1.FavoriteColor = "Red";
            user1.DOB = "2/28/1993";

            users.Add(user1);

            Users user2 = new Users();
            user2.Name = "Mia";
            user2.ID = 2;
            user2.FavoriteColor = "Purple";
            user2.DOB = "5/26/1995";

            users.Add(user2);

            Users user3 = new Users();
            user3.Name = "Shaq";
            user3.ID = 3;
            user3.FavoriteColor = "Blue";
            user3.DOB = "7/12/1994";

            users.Add(user3);

            Users user4 = new Users();
            user4.Name = "Larissa";
            user4.ID = 4;
            user4.FavoriteColor = "Orange";
            user4.DOB = "2/2/1994";

            users.Add(user4);

            Users user5 = new Users();
            user5.Name = "Andrew";
            user5.ID = 5;
            user5.FavoriteColor = "Yellow";
            user5.DOB = "1/26/1994";

            users.Add(user5);

            Users user6 = new Users();
            user6.Name = "Noah";
            user6.ID = 6;
            user6.FavoriteColor = "Black";
            user6.DOB = "7/31/2012";

            users.Add(user6);

            Users user7 = new Users();
            user7.Name = "Damien";
            user7.ID = 7;
            user7.FavoriteColor = "Green";
            user7.DOB = "12/20/2012";

            users.Add(user7);

            Users user8 = new Users();
            user8.Name = "Jamal";
            user8.ID = 8;
            user8.FavoriteColor = "White";
            user8.DOB = "6/9/1969";

            users.Add(user8);

            Users user9 = new Users();
            user9.Name = "Spencer";
            user9.ID = 9;
            user9.FavoriteColor = "Maroon";
            user9.DOB = "11/8/1999";

            users.Add(user9);

            Users user10 = new Users();
            user10.Name = "Teddy";
            user10.ID = 10;
            user10.FavoriteColor = "Brown";
            user10.DOB = "3/7/2000";

            users.Add(user10);

            List<Users> result = users.Where(users => users.FavoriteColor == "Yellow").ToList();

            foreach(var user in result)
            {
                Console.WriteLine(user.Name);
                Console.WriteLine(user.ID);
                Console.WriteLine(user.FavoriteColor);
                Console.WriteLine(user.DOB);
            }
            
        }
    }
}


