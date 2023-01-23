using System.ComponentModel.DataAnnotations;

namespace TemplateApi.Models
{
    public class UpdatePassword
    {
        [MinLength(6), MaxLength(20)]
        public String Password { get; set; } = string.Empty;
    }
}