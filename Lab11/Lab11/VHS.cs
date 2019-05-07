using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }

        public VHS(string Title, string Category, int RunTime, List<string> Scenes)
            : base(Title, Category, RunTime, Scenes)
        {
            CurrentTime = 0;
        }
        public override void Play()
        {
            //that plays the scene at the current time and then increments CurrentTime. 

            for(int i = CurrentTime; i < Scenes.Count; i++)
            {
                Console.WriteLine($"The current time is {i}");
                Console.WriteLine($"Playing scene: {Scenes[i]}");
                CurrentTime += i;
            }

            Console.WriteLine();
            //Console.WriteLine($"Final current time is: {CurrentTime}"); //test
        }

        public void Rewind()
        {
            CurrentTime = 0;
            //Console.WriteLine($"The current time is: {CurrentTime}"); //test
        }

    }
}
