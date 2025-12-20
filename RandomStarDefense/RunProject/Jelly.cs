using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunProject
{
    public record class Jelly
    {
        [JsonProperty("Speed")] public int Speed;
        [JsonProperty("Name")] public string Name;
        [JsonProperty("Score ")] public int Score;
        int moveTick;
        int x;
        public int y;


        public void Update()
        {
            moveTick++;
            if (Speed <= moveTick)
            {

                x--;


                if(x <= 0)
                {
                    x = 50;
                }
            }
        }

        public void Draw(ConsoleRenderer renderer)
        {
            renderer.Print(x, y, Name);
        }

        public void GetScore(int px, int py, ref int currentscore)
        {
            if(x == px && y == py)
            {
                currentscore += Score;

                x = 50;
            }
        }
    };
}
