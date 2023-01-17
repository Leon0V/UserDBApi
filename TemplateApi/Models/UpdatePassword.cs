using System.ComponentModel.DataAnnotations;

namespace LoginApi.Models.Users
{
    public class UpdatePassword
    {
        [MinLength(6), MaxLength(20)]
        public String Password { get; set; } = string.Empty;
    }
}