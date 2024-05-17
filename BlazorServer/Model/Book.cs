using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public int AuthorID { get; set; }
        [ForeignKey("AuthorID")]
        public Author Author { get; set; }  // Navigation property

        [Required]
        [MaxLength(20)]
        public string ISBN { get; set; }

        [Required]
        public int GenreID { get; set; }
        [ForeignKey("GenreID")]
        public Genre Genre { get; set; }  // Navigation property

        [Required]
        public int PublisherID { get; set; }
        [ForeignKey("PublisherID")]
        public Publisher Publisher { get; set; }  // Navigation property

        [Required]
        public DateTime PublishDate { get; set; }

        [Required]
        public int QuantityAvailable { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }
    }
}
