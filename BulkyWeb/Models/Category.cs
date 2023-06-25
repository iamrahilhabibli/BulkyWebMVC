using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models;

public class Category
{
    [Key] // <= This is Datannotation
    public int Id { get; set; }
    public string Name { get; set; }
    public int DisplayOrder { get; set; }
}
