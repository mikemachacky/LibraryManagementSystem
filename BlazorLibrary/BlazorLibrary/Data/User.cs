using System.ComponentModel.DataAnnotations;

namespace BlazorLibrary.Data
{
    public class User
    {
        [EmailAddress]
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Role { get; set; } = string.Empty ;
    }
}
