using System;
using System.IO;

namespace Maze
{
    internal class Maze
    {
        #region Private Fields

        private Case[] board;

        private int length;
        private int emptyCase;
        private double lineCount;
        private double lineLength;
        #endregion Private Fields

        #region Public Constructors

        public Maze()
        {
            length = 0;
            lineLength = 0;
            lineCount = 0;
            board = null;
        }

        #endregion Public Constructors

        #region Public Properties

        public int Emptycase
        {
            get { return emptyCase; }
        }

        public int Length
        {
            get { return length; }
        }

        internal Case[] Board
        {
            get
            {
                return board;
            }

            set
            {
                board = value;
            }
        }

        #endregion Public Properties

        #region Public Methods

        public void addEntity(Entity entity, int coord)
        {
            board[coord].Entity = entity;
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

                    while (sr.EndOfStream == false)
                    {
                        sr.ReadLine();
                        lineCount += 1;
                    }

                    sr.BaseStream.Position = 0;
                    sr.DiscardBufferedData();

                    double temp = lineCount * lineLength;
                    length = Convert.ToInt32(temp);
                    board = new Case[length];
                    int count = 0;
                    for (int j = 0; j < length / lineLength; j++)
                    {
                        string tempLine = sr.ReadLine();
                        for (int i = 0; i < tempLine.Length; i++)
                        {
                            if (tempLine[i] == '0')
                            {
                                board[count] = new Case(Case.CaseType.empty);
                                emptyCase += 1;
                                count += 1;
                            }
                            else if (tempLine[i] == '1')
                            {
                                board[count] = new Case(Case.CaseType.wall);
                                count += 1;
                            }
                            else if (tempLine[i] == '2')
                            {
                                board[count] = new Case(Case.CaseType.exit);
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
                    if (board[count].Type == Case.CaseType.empty || board[count].Type == Case.CaseType.exit)
                    {
                        
                        Console.Write(" ");
                    }
                    if (board[count].Entity!= null)
                    {
                       
                        Console.Write("O");
                    }
                    if (board[count].Type == Case.CaseType.wall)
                    {
                       
                        Console.Write("*");
                    }
                    count++;

                }
                Console.WriteLine("\n");
            }
        }

        #endregion Public Methods
    }
}