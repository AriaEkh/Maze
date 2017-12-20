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
            Console.WriteLine("Enter the filename: ");
            string filename = Console.ReadLine();
            Game test = new Game(filename);
            test.ShowMaze();
            
        }
        static void Main(string[] args)
        {
            Start();
            Console.ReadKey();
        }
    }
}
