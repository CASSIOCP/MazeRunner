namespace MazeRunner
{
    public class Path
    {
        public int Cost = int.MaxValue;
        public int Source;
        public bool IsStart = false;
        public bool IsExit = false;
    }
}