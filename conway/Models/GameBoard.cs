using System.ComponentModel.DataAnnotations;

namespace conway.Models
{
    public class GameBoard
    {
        [Range(10,100), Required]
        public int Height { get; set; }
        
        [Range(10,100), Required]
        public int Width { get; set; }
        public int[,]? Board { get; set; }
    }
}
