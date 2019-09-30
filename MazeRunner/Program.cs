namespace MazeRunner
{
    class Program
    {
        static void Main()
        {
            var maze = FileReader.GetMaze();

            if (maze == null)
                return;

            MazeRun.Run(maze);
        }
    }
}