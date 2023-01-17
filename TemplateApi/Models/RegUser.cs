using System.ComponentModel.DataAnnotations;

namespace LoginApi.Models.Users
{
    public class RegUser
    {
        [Required]
        [MinLength(6), MaxLength(20)]
        public string Login { get; set; } = string.Empty;
        [Required]
        [MinLength(6)]
        public string Password { get; set; } = string.Empty;
        [Required]
        [MinLength(6), MaxLength(40)]
        public string Name { get; set; } = string.Empty;

    }
}