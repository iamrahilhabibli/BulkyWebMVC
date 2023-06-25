using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models;

public class Category
{
    [Key] // <= This is DataAnnotation - You can use this if PK name would be anything custom
    public int Id { get; set; }
    [Required]
    [DisplayName("Category Name")]
    [MaxLength(30)]
    public string Name { get; set; }
    [DisplayName("Display Order")]
    [Range(1,100)]
    public int DisplayOrder { get; set; }
}
