using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace Lab11
{
    public class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }

        public Movie(string Title, string Category, int RunTime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes;
        }

        public virtual void PrintInfo()
        {
            // print out all the scenes in the scene list, so use PrintScenes() here.
            Console.WriteLine();
            Console.WriteLine("Movie Info: ");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Title: {Category}");
            Console.WriteLine($"Title: {RunTime}");
            PrintScenes();
        }

        public void PrintScenes()
        {
            // print out each movie scene
            //prints all the scenes in the list along with their index. 
            for(int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"Scene: {i + 1}) {Scenes[i]}");
            }
        }

        public virtual void Play()
        {
            Console.WriteLine("The play method only works on visual media");
        }

    }
}
