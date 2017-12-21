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

    }       
}
