using System.Linq;
using System.Collections.Generic;

namespace MazeRunner
{
    public static class SolutionBuilder
    {
        public static Maze Build(int rows, int cols, Dictionary<int, Path> paths)
        {
            var solution = InitializeMaze(rows, cols);

            var destinationNode = paths.FirstOrDefault(a => a.Value.IsExit);

            while (destinationNode.Value.Cost >= 0)
            {
                char value;

                if (destinationNode.Value.IsExit)
                    value = MazeCell.Exit;
                else if (destinationNode.Value.IsStart)
                    value = MazeCell.Start;
                else
                    value = MazeCell.Path;

                if (destinationNode.Key < cols)
                    solution.Board[0, destinationNode.Key] = value;
                else
                    solution.Board[(destinationNode.Key / cols), destinationNode.Key % cols] = value;

                if (destinationNode.Value.Cost == 0)
                    break;

                destinationNode = paths.FirstOrDefault(a => a.Key == destinationNode.Value.Source);
            }

            return solution;
        }

        private static Maze InitializeMaze(int rows, int cols)
        {
            var solution = new Maze(rows, cols);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    solution.Board[i, j] = MazeCell.Block;
                }
            }

            return solution;
        }
    }
}