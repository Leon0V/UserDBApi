using System.ComponentModel.DataAnnotations;

namespace TemplateApi.Models
{
    public class UpdateUser
    {
        public string Name { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }
    }
}