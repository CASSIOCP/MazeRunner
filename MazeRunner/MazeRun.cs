using System;
using System.Linq;

namespace MazeRunner
{
    public static class MazeRun
    {
        public static void Run(Maze maze)
        {
            var paths = FindPath.Find(maze);

            if (paths == null)
            {
                Console.Write("Not found!");
                return;
            }

            var solution = SolutionBuilder.Build(maze.Rows, maze.Cols, paths);
            var steps = paths.FirstOrDefault(a => a.Value.IsExit).Value.Cost;

            PrintPath.Print(solution, steps);
        }
    }
}
