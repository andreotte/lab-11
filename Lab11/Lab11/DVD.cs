using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class DVD : Movie
    {
        public DVD(string Title, string Category, int RunTime, List<string> Scenes) 
            : base(Title, Category, RunTime, Scenes) 
        {

        }

        public override void Play()
        {
            string scene = "";
            PrintScenes();
            Console.WriteLine("What scene would you like to see?");
            string input = Console.ReadLine();

            try
            {
                int index = int.Parse(input);
                scene = Scenes[index - 1];
                Console.WriteLine($"Playing \"{scene}\"");
            }

            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    Console.WriteLine("I didn't catch that. Please enter input as an integer corresponding to the menu options.");
                    Console.WriteLine();
                    Play();
                }
                else if (ex is ArgumentOutOfRangeException)
                {
                    Console.WriteLine("That scene is only available in the extended version. I heard Netflix has that one. Please try again.");
                    Console.WriteLine();
                    Play();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again");
                }
            }
        }
    }
}
