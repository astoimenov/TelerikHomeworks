namespace Minesweeper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Mines
    {
        public static void Main(string[] args)
        {
            string command = string.Empty;
            char[,] field = CreatePlayingField();
            char[,] bombs = CreateBombs();
            int currentScore = 0;
            int row = 0;
            int col = 0;
            bool hitBomb = false;
            bool isNewGame = true;
            bool isWon = false;

            List<Points> highScorers = new List<Points>(6);

            const int Maks = 35;

            do
            {
                if (isNewGame)
                {
                    Console.WriteLine("Let's play \"Minesweeper\". Try to find all fields that haven't mines.");
                    Console.WriteLine("Commands: 'top' - shows the scores, 'restart' - starts new game, 'exit' - exits from the game!");
                    Render(field);
                    isNewGame = false;
                }

                Console.Write("Enter row ad column : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out col) &&
                        row <= field.GetLength(0) && col <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        Rating(highScorers);
                        break;
                    case "restart":
                        field = CreatePlayingField();
                        bombs = CreateBombs();
                        Render(field);
                        hitBomb = false;
                        isNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye bye!");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                SurroundingBombsCount(field, bombs, row, col);
                                currentScore++;
                            }

                            if (Maks == currentScore)
                            {
                                isWon = true;
                            }
                            else
                            {
                                Render(field);
                            }
                        }
                        else
                        {
                            hitBomb = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError! Invalid command!\n");
                        break;
                }

                if (hitBomb)
                {
                    Render(bombs);
                    Console.WriteLine("\nGame over! Your score: {0} ", currentScore);
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Points score = new Points(name, currentScore);
                    if (highScorers.Count < 5)
                    {
                        highScorers.Add(score);
                    }
                    else
                    {
                        for (int i = 0; i < highScorers.Count; i++)
                        {
                            if (highScorers[i].Points < score.Points)
                            {
                                highScorers.Insert(i, score);
                                highScorers.RemoveAt(highScorers.Count - 1);
                                break;
                            }
                        }
                    }

                    highScorers.Sort((Points r1, Points r2) => r2.Name.CompareTo(r1.Name));
                    highScorers.Sort((Points r1, Points r2) => r2.Points.CompareTo(r1.Points));
                    Rating(highScorers);

                    field = CreatePlayingField();
                    bombs = CreateBombs();
                    currentScore = 0;
                    hitBomb = false;
                    isNewGame = true;
                }

                if (isWon)
                {
                    Console.WriteLine("\nBRAVO! You won!");
                    Render(bombs);
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Points points = new Points(name, currentScore);
                    highScorers.Add(points);
                    Rating(highScorers);
                    field = CreatePlayingField();
                    bombs = CreateBombs();
                    currentScore = 0;
                    isWon = false;
                    isNewGame = true;
                }
            }
            while (command != "exit");
        }

        private static void Rating(List<Points> points)
        {
            Console.WriteLine("\nPoints:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} cells", i + 1, points[i].Name, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty rating!\n");
            }
        }

        private static void SurroundingBombsCount(char[,] field, char[,] bombs, int row, int col)
        {
            char bombsCount = GetSurroundingBombsCount(bombs, row, col);
            bombs[row, col] = bombsCount;
            field[row, col] = bombsCount;
        }

        private static void Render(char[,] board)
        {
            int rowCount = board.GetLength(0);
            int colCount = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rowCount; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < colCount; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreatePlayingField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] CreateBombs()
        {
            int rows = 5;
            int cols = 10;
            char[,] playingField = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    playingField[i, j] = '-';
                }
            }

            List<int> bombMap = new List<int>();
            while (bombMap.Count < 15)
            {
                Random randomInt = new Random();
                int randomLocation = randomInt.Next(50);
                if (!bombMap.Contains(randomLocation))
                {
                    bombMap.Add(randomLocation);
                }
            }

            foreach (int bombLocation in bombMap)
            {
                int col = bombLocation / cols;
                int row = bombLocation % cols;
                if (row == 0 && bombLocation != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                playingField[col, row - 1] = '*';
            }

            return playingField;
        }

        private static char GetSurroundingBombsCount(char[,] r, int rr, int rrr)
        {
            int bombsCount = 0;
            int rowCount = r.GetLength(0);
            int colCount = r.GetLength(1);

            if (rr - 1 >= 0)
            {
                if (r[rr - 1, rrr] == '*')
                {
                    bombsCount++;
                }
            }

            if (rr + 1 < rowCount)
            {
                if (r[rr + 1, rrr] == '*')
                {
                    bombsCount++;
                }
            }

            if (rrr - 1 >= 0)
            {
                if (r[rr, rrr - 1] == '*')
                {
                    bombsCount++;
                }
            }

            if (rrr + 1 < colCount)
            {
                if (r[rr, rrr + 1] == '*')
                {
                    bombsCount++;
                }
            }

            if ((rr - 1 >= 0) && (rrr - 1 >= 0))
            {
                if (r[rr - 1, rrr - 1] == '*')
                {
                    bombsCount++;
                }
            }

            if ((rr - 1 >= 0) && (rrr + 1 < colCount))
            {
                if (r[rr - 1, rrr + 1] == '*')
                {
                    bombsCount++;
                }
            }

            if ((rr + 1 < rowCount) && (rrr - 1 >= 0))
            {
                if (r[rr + 1, rrr - 1] == '*')
                {
                    bombsCount++;
                }
            }

            if ((rr + 1 < rowCount) && (rrr + 1 < colCount))
            {
                if (r[rr + 1, rrr + 1] == '*')
                {
                    bombsCount++;
                }
            }

            return char.Parse(bombsCount.ToString());
        }
    }
}
