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
        private int[,] Board;

        public Game(string file)
        {
            CreateMaze(file);
        }

        public void CreateMaze(string file)
        {
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
