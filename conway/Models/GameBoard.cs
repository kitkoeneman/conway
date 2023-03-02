using System.ComponentModel.DataAnnotations;

namespace conway.Models
{
    public class GameBoard
    {
        [Range(10,100)]
        public int Height { get; set; }
        
        [Range(10,100)]
        public int Width { get; set; }
        public int[,,]? Board { get; set; }

        public GameBoard(int height, int width)
        {
            Height = height; 
            Width = width;
        }
    }


}
