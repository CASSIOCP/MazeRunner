namespace MazeRunner
{
    public class Maze
    {
        public Maze(int rows, int cols)
        {
            Board = new char[rows, cols];
        }

        public char[,] Board;
        public int Rows => Board.GetLength(0);
        public int Cols => Board.GetLength(1);
    }
}