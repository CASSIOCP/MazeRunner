using System.IO;
using System;

namespace MazeRunner
{
    public static class FileReader
    {
        private const string FilePath = "../../../maze.txt";

        public static Maze GetMaze()
        {
            if (File.Exists(FilePath) == false)
                return null;

            var lines = File.ReadAllLines(FilePath);

            var rows = Convert.ToInt32(lines[0]);
            var cols = Convert.ToInt32(lines[1]);
            var maze = new Maze(rows, cols);

            for (int i = 0; i < rows; i++)
            {
                string line = lines[2 + i];
                for (int j = 0; j < cols; j++)
                {
                    maze.Board[i, j] = line[j];
                }
            }

            return maze;
        }
    }
}