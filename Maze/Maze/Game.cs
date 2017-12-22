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

        public int FoundEmptyAlea(int alea)
        {
            int[] list =new int[maze.Length];
            for (int i=0;i<maze.Length;i++)
            {
                list[i] = -1;
            }
            int count = 0;
            for (int i = 0; i < maze.Length; i++)
            {
                if(maze.Board[i].Type== Case.CaseType.empty)
                {
                    list[count] = i;
                    count++;
                }
            }
            return list[alea];



        }

        public void PlacePlayer()
        {
            int numberPlayer = (int)Math.Round(maze.Emptycase*0.01,0);
            Console.WriteLine(numberPlayer);
            for (int i=0;i< numberPlayer;i++)
            {
                Random rnd = new Random();
                int alea = rnd.Next(0, maze.Emptycase-1);
                int position = FoundEmptyAlea(alea);
                Player player = new Player(i);
                maze.addEntity(player, position);
                

                 
                
           }
        }
        

    }       
}
