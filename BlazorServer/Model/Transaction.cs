using System.ComponentModel.DataAnnotations;

namespace BlazorServer.Model
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }

        [Required]
        public int UserID { get; set; }

        [Required]
        public int BookID { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        public DateTime? ReturnedDate { get; set; }

        [Required]
        [MaxLength(50)]
        public string Status { get; set; }
    }
}
