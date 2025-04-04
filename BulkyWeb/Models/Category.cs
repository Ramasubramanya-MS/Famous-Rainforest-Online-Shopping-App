using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        // Using data annotation as the primary key
        [Key]
        public int Id { get; set; }
        // Not Null Setting
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [Range(1,100)]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
