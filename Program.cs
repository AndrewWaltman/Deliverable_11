using System;
using System.Collections.Generic;

namespace Deliverable_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcomes user.
            Console.WriteLine("Welcome to the Movie List Application");
            //Immediately runs Menu();
            Menu();
        }
        public static bool Menu()
        {
            //When we see this, we have to understand what is happening in Movies.cs
            // ==================See Movies.cs for more============================
            //Once we get that, we realize that Movies has to have Two Strings: Title and Category.
            //This works similarly to parameters in methods!
            //And with this, we have to have a title and category for each movie.
            Movie ironGiant = new Movie("The Iron Giant", "animated");
            Movie spiderman = new Movie("Spiderman: Into the Spiderverse", "animated");
            Movie bossBaby = new Movie("Boss Baby", "animated");
            Movie theGodfather = new Movie("The Godfather", "drama");
            Movie shawShank = new Movie("Shaw Shank Redemption", "drama");
            Movie toughGuys = new Movie("Tough Guys Don't Dance", "drama");
            Movie getOut = new Movie("Get Out", "horror");
            Movie psycho = new Movie("Psycho", "horror");
            Movie theRoom = new Movie("The Room (By Tommy Wiseau)", "horror");
            Movie starWars = new Movie("Star Wars", "scifi");
            Movie starTrek = new Movie("Star Trek", "scifi");
            Movie spaceBalls = new Movie("Space Balls", "scifi");

            //We create this list of titles with the Movie names above.
            List<Movie> title = new List<Movie> { ironGiant, spiderman, bossBaby, theGodfather, shawShank, toughGuys, getOut, psycho, theRoom, starWars, starTrek, spaceBalls };

            //Create a bool to return to later.
            bool menu = true;
            //Create a while loop to continue while true when going through the later if and for statements.
            while (menu)
            {
                Console.WriteLine("Which genre of movie are you looking for?");
                Console.WriteLine("Animated");
                Console.WriteLine("Drama");
                Console.WriteLine("Horror");
                Console.WriteLine("SciFi");
                string input = Console.ReadLine().ToLower().Trim();

                Console.WriteLine("Here are the movies we have under that category.\n==============================");

                //This is where we reapply the Objects from earlier.
                //First we have the regular "i formula" for for loops.
                //Just this time we are using the "title" count from Movies.
                for (int i = 0; i < title.Count; i++)
                {
                    Movie m = title[i]; //Sets a Movie type (m) to use for each title[i](searches the current title name) fot the next statement.
                    if (m.Category == input) //if the user input matches a Movie Category, we are set to write out the Title.
                    {            // Also works with title[i] and instead of naming EVERY title, it just names the input matched title.
                        Console.WriteLine(m.Title); //Writes out the Movie Title.
                    }
                }
                Console.WriteLine("==============================");
                break;
                //Ends the conditional.
            }
            //Continues to whether or not the user wishes to continue.
            return Continue();
        }
        //Continue method I've already seen before.
        public static bool Continue()
        {
            Console.WriteLine("Would you like to continue? (Y/N)");
            string inputYN = Console.ReadLine().ToLower().Trim();

            if (inputYN == "y")
            {
                Console.Clear();
                return Menu();
            }
            else if (inputYN == "n")
            {
                Console.WriteLine("Thank you.");
                return false;
            }
            else
            {
                Console.WriteLine("That is not a valid response, please just type 'y' or 'n'");
                return Continue();
            }
        }
    }
}


            
       
