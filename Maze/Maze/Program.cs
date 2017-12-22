using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Program
    {
        private static void Start()
        {
            Game test = new Game("maze.txt");
          
            test.PlacePlayer();
            test.ShowMaze();


        }
        static void Main(string[] args)
        {
            Start();
            
            Console.ReadKey();
        }
    }
}
