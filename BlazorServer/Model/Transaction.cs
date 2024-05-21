using BlazorServer.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorServer.Model
{
        public class Transaction
        {
            [Key]
            public int TransactionID { get; set; }

            [Required]
            public string UserID { get; set; }
            [ForeignKey("UserID")]
            public ApplicationUser User { get; set; } // Navigation property for User

            [Required]
            public int BookID { get; set; }
            [ForeignKey("BookID")]
            public Book Book { get; set; } // Navigation property for Book

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
