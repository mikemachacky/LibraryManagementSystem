using System.ComponentModel.DataAnnotations;

namespace BlazorServer.Model
{
    public class Publisher
    {
        [Key]
        public int PublisherID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
    }
}
