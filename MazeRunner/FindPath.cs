using System.Collections.Generic;

namespace MazeRunner
{
    public static class FindPath
    {
        static Maze Maze;
        static readonly Dictionary<int, Path> Paths = new Dictionary<int, Path>();

        public static Dictionary<int, Path> Find(Maze maze)
        {
            Maze = maze;

            return PathExist() == false ? null : Paths;
        }

        private static bool PathExist()
        {
            return Search(0, 0, new Path() { Cost = 0, IsStart = true });
        }

        private static bool Search(int row, int col, Path path)
        {
            if (row < 0 || col < 0 || row >= Maze.Rows || col >= Maze.Cols || Maze.Board[row, col] == MazeCell.Block)
            {
                return false;
            }

            int key = (row * Maze.Cols) + col;

            if (Paths.ContainsKey(key) && Paths[key].Cost <= path.Cost)
            {
                return false;
            }

            Paths[key] = path;

            if (Maze.Board[row, col] == MazeCell.Exit)
            {
                Paths[key].IsExit = true;
                return true;
            }

            Path p = new Path()
            {
                Cost = path.Cost + 1,
                Source = key,
            };

            return
                Search(row + 1, col, p) |
                Search(row, col + 1, p) |
                Search(row - 1, col, p) |
                Search(row, col - 1, p);
        }
    }
}