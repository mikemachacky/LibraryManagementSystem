using System.ComponentModel.DataAnnotations;

namespace BlazorServer.Model
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }

        [Required]
        public int UserID { get; set; }

        [Required]
        public int BookID { get; set; }

        [Required]
        public int Rating { get; set; }

        [MaxLength(1000)]
        public string ReviewText { get; set; }

        [Required]
        public DateTime ReviewDate { get; set; }
    }
}
