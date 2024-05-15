using System.ComponentModel.DataAnnotations;

namespace BlazorServer.Model
{
    public class Genre
    {
        [Key]
        public int GenreID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
