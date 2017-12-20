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
        enum Case {empty, wall, exit};
        private Case[] Board;
        private int length;
        private int lineLength;


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
                    String line = sr.ReadLine();
                    this.lineLength = line.Length;
                    
                    sr.BaseStream.Position = 0;
                    sr.DiscardBufferedData();

                    String fullFile = sr.ReadToEnd();
                    this.length = fullFile.Length;

                    sr.BaseStream.Position = 0;
                    sr.DiscardBufferedData();

                    this.Board = new Case[length];
                    Console.WriteLine((char)sr.Read());
                    for (int i = 0; i < length; i++)
                    {
                        if((char)sr.Read() == '0')
                        {
                            Board[i] = Case.empty;
                        }
                        else if ((char)sr.Read() == '1')
                        {
                            Board[i] = Case.wall;
                        }
                        else if ((char)sr.Read() == '2')
                        {
                            Board[i] = Case.exit;
                        }

                    }
                    
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void ShowMaze()
        {
            for (int j = 0; j < length/lineLength; j++)
            {
                for (int i = 0; i < lineLength; i++)
                {
                    if (Board[i] == Case.empty || Board[i] == Case.exit)
                    {
                        Console.Write(" ");
                    }
                    else if (Board[i] == Case.wall)
                    {
                        Console.Write("#");
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}
