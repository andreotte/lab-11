using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{

    class Blockbuster
    {
        public List<Movie> Movies { get; set; }

        public Blockbuster()
        {
            this.Movies = new List<Movie>(){
                new DVD("Spaceballs", "Comedy", 120, new List<string>() { "Capture Vespa", "Blow Up DeathStar", "Pizza the Hut" }),
                new DVD("Star Wars Holiday Special", "Hot Mess", 80, new List<string>() { "Cantina Scene", "Jefferson Starship", "Bobba Fett Cartoon" }),
                new DVD("The Sandlot", "Comedy", 80, new List<string>() { "Scary Dog", "Babe Ruth Baseball Home Run", "Friendly Dog" }),
                new VHS("Dumb and Dumber", "Comedy", 90, new List<string>() { "Swindle Blind Kid", "Kill Gas Man", "Buy Leisure Suits" }),
                new VHS("I Am Legend", "Thriller", 110, new List<string>() { "Empty City", "Kill Zombies", "Glimmer of Hope" }),
                new VHS("Finding Nemo", "Kids", 100, new List<string>() { "Touch the Boat", "Takin' on the Jellies", "Happiness" })};
        }

        public void AddMovie(Movie movie)
        {
            Movies.Add(movie);
        }

        public void PrintMovies()
        {
            Console.WriteLine("Movies in stock:");

            for (int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {Movies[i].Title}");
            }
        }

        public void Checkout()
        {
            PrintMovies();
            Console.WriteLine("What movie would you like to check out?");
            string input = Console.ReadLine();

            try
            {
                int index = int.Parse(input);
                Movies[index - 1].PrintInfo();
            }

            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    Console.WriteLine("Sorry, that one isn't in stock. Please try again.");
                    Console.WriteLine();
                    Checkout();
                }
                else if (ex is ArgumentOutOfRangeException)
                {
                    Console.WriteLine("I didn't catch that. Please enter input as an integer corresponding to the menu options.");
                    Console.WriteLine();
                    Checkout();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again");
                }
            }
        }

        //public void MovieTester()
        //{
        //    //this.Movies[1].Play();
        //    this.Movies[5].Play();
        //}

    }
}