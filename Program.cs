using System;
using System.Collections.Generic;

namespace Deliverable_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //I do not know how this works.
            //I don't know if what I'm missing. What parameters need to be set, and how to set them. 
            //I don't even know how to return the Continue() method wehen the answer is "y" without creating a new method to take its place.
            //I'm hoping things will clear up in future classes, but currently I am stuck.
            

            //A list of movies, each with their own genre.
            List<string> titles = new List<string>();
            titles.Add("The Iron Giant");
            titles.Add("Spiderman: Into the Spiderverse");
            titles.Add("Boss Baby");
            titles.Add("The Godfather");
            titles.Add("Shaw Shank Redemption");
            titles.Add("Tough Guys Don't Dance");
            titles.Add("Get Out");
            titles.Add("Psycho");
            titles.Add("The Room (By Tommy Wiseau)");
            titles.Add("Star Wars");
            titles.Add("Star Trek");
            titles.Add("Space Balls");

            Console.WriteLine("Welcome to the Movie Lit st Application");
            Console.WriteLine("Which genre of movie are you looking for?");
            string categoryInput = Console.ReadLine().ToLower().Trim();

            Movies a = new Movies(categoryInput, "");

            Continue();
        }
        
        //Method for continuing or not.
        public static bool Continue()
        {
            Console.WriteLine("Would you like to continue? (Y/N)");
            string inputYN = Console.ReadLine().ToLower().Trim();

            if (inputYN == "y")
            {
                return true;
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
