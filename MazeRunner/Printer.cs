using System;

namespace MazeRunner
{
    public static class PrintPath
    {
        public static void Print(Maze maze, int steps)
        {
            Console.WriteLine($"Maze: {maze.Rows} x {maze.Cols}");
            Console.WriteLine($"Steps: {steps}");
            Console.WriteLine($"Path:\n");

            for (int i = 0; i < maze.Rows; i++)
            {
                for (int j = 0; j < maze.Cols; j++)
                {
                    Console.Write($"{maze.Board[i, j]}");
                }

                Console.WriteLine();
            }
        }
    }
}