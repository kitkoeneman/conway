namespace conway.Models
{
    public class GameBoard
    {
        public int Height { get; }
        public int Width { get; }
        public int[,,]? Board { get; }
    }
}
