using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Game
    {
        private Maze maze;
        private int playerCount;


        public Game(string file)
        {
            playerCount = 0;
            maze = new Maze();
            maze.CreateMaze(file);
        }

        public void ShowMaze()
        {
            maze.ShowMaze();
        }

        /*public void PlacePlayer()
        {
            double percent = Math.Floor(maze.Length * 0.10);
            Random rnd = new Random();
            for (int i = 1; i <= percent; i++)
            {
                Player player = new Player();
                player.Id = i;
                int coord = rnd.Next(maze.Length);
                while(maze != )

            }
        }*/

    }       
}
