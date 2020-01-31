using System;
using System.Collections.Generic;

namespace Deliverable_11
{
    class Program
    {
        static void Main(string[] args)
        {

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

            Console.WriteLine("This is the Movie List Application 1.0");
            Console.WriteLine("We have a good selection of movies to choose from. Which genre are you interested in?");
            string genreInput = Console.ReadLine().Trim().ToLower();
        
        }

    }
}
