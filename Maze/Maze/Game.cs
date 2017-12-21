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
        private int playerCount;


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
                    int count = 0;
                    for (int j = 0; j < length/lineLength; j++)
                    {
                        string tempLine = sr.ReadLine();
                        for (int i = 0; i < tempLine.Length; i++)
                        {
                            if (tempLine[i] == '0')
                            {
                                Board[count] = Case.empty;
                                count += 1;
                            }
                            else if (tempLine[i] == '1')
                            {
                                Board[count] = Case.wall;
                                count += 1;
                            }
                            else if (tempLine[i] == '2')
                            {
                                Board[count] = Case.exit;
                                count += 1;
                            }

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
            int count = 0;
            for (int j = 0; j < length/lineLength; j++)
            {
                for (int i = 0; i < lineLength; i++)
                {
                    if (Board[count] == Case.empty || Board[count] == Case.exit)
                    {
                        count ++;
                        Console.Write(" ");
                    }
                    else if (Board[count] == Case.wall)
                    {
                        count++;
                        Console.Write("|");
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}
