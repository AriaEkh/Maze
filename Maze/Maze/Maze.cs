using System;
using System.IO;

namespace Maze
{
    internal class Maze
    {
        #region Private Fields

        private Case[] board;

        private int length;

        private double lineLength;

        double lineCount;

        #endregion Private Fields

        #region Private Enums

        private enum Case
        { empty, wall, exit };
        #endregion Private Enums

        public Maze()
        {
            length = 0;
            lineLength = 0;
            lineCount = 0;
            board = null;
        }

        #region Public Methods

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

                    while(sr.EndOfStream==false)
                    {
                        sr.ReadLine();
                        lineCount++;
                    }

                    sr.BaseStream.Position = 0;
                    sr.DiscardBufferedData();

                    double temp = lineCount * lineLength;
                    length = Convert.ToInt32(temp);
                    this.board = new Case[length];
                    int count = 0;
                    for (int j = 0; j < length / lineLength; j++)
                    {
                        string tempLine = sr.ReadLine();
                        for (int i = 0; i < tempLine.Length; i++)
                        {
                            if (tempLine[i] == '0')
                            {
                                board[count] = Case.empty;
                                count += 1;
                            }
                            else if (tempLine[i] == '1')
                            {
                                board[count] = Case.wall;
                                count += 1;
                            }
                            else if (tempLine[i] == '2')
                            {
                                board[count] = Case.exit;
                                count += 1;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void ShowMaze()
        {
            int count = 0;
            for (int j = 0; j < lineCount; j++)
            {
                for (int i = 0; i < lineLength; i++)
                {
                    if (board[count] == Case.empty || board[count] == Case.exit)
                    {
                        count++;
                        Console.Write(" ");
                    }
                    else if (board[count] == Case.wall)
                    {
                        count++;
                        Console.Write("*");
                    }
                }
                Console.WriteLine("\n");
            }
        }
        #endregion Public Methods
    }
}