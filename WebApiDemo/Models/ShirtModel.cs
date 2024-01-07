using System.ComponentModel.DataAnnotations;

namespace WebApiDemo.Models
{
    public class ShirtModel
    {
        public int ShirtId { get; set; }
        [Required]
        public string? Brand { get; set; }
        [Required]
        public string? Colour { get; set; }
        public int? Size { get ;set; }
        [Required]
        public string? Gender { get; set; }

        public double? Price { get; set; }


    }
}
