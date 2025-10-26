using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Model;

public class Category
{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Title is required")]
    [MinLength(3, ErrorMessage = "Title must be at least 3 characters")]
    [MaxLength(60, ErrorMessage = "Title must be less than 60 characters")]
    public string Title { get; set; } = string.Empty;
    
    



}