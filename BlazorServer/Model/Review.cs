using BlazorServer.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorServer.Model
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }

        [Required]
        public int UserID { get; set; }
        [ForeignKey("Id")]
        public ApplicationUser User { get; set; } // Navigation property for User

        [Required]
        public int BookID { get; set; }
        [ForeignKey("BookID")]
        public Book Book { get; set; } // Navigation property for Book

        [Required]
        public int Rating { get; set; }

        [MaxLength(1000)]
        public string ReviewText { get; set; }

        [Required]
        public DateTime ReviewDate { get; set; }
    }
}
