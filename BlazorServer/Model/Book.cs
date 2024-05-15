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
        public string AuthorID { get; set; }

        [Required]
        [MaxLength(20)]
        public string ISBN { get; set; }

        [Required]
        public string GenreID { get; set; }

        [Required]
        public string PublisherID { get; set; }

        [Required]
        public DateTime PublishDate { get; set; }

        [Required]
        public int QuantityAvailable { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }
    }
}
