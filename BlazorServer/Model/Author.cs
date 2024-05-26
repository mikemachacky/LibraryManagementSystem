using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BlazorServer.Model
{
    public class Author
    {
        [Key]
        public int AuthorID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Bio { get; set; }

        [MaxLength(100)]
        public string Nationality { get; set; }
    }
}
