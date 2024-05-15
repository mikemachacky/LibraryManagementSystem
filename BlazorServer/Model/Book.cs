using System.ComponentModel.DataAnnotations;

namespace BlazorServer.Model
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [Required]
        [MaxLength(100)]
        public string Author { get; set; }

        [Required]
        [MaxLength(20)]
        public string ISBN { get; set; }

        [Required]
        [MaxLength(50)]
        public string Genre { get; set; }

        [Required]
        [MaxLength(100)]
        public string Publisher { get; set; }

        [Required]
        public DateTime PublishDate { get; set; }

        [Required]
        public int QuantityAvailable { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }
    }
}
