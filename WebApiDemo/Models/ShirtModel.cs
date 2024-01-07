using System.ComponentModel.DataAnnotations;
using WebApiDemo.Models.Validations;

namespace WebApiDemo.Models
{
    public class ShirtModel
    {
        public int ShirtId { get; set; }
        [Required]
        public string? Brand { get; set; }
        [Required]
        public string? Colour { get; set; }
        [Shirt_EnsureCorrectSizing]
        public int? Size { get ;set; }
        [Required]
        public string? Gender { get; set; }

        public double? Price { get; set; }


    }
}
