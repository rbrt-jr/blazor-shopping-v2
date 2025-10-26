using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Model;

public class Product
{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Title is required")]
    [MinLength(3, ErrorMessage = "Title must be at least 3 characters")]
    [MaxLength(120, ErrorMessage = "Title must be less than 120 characters")]
    public string Title { get; set; } = string.Empty;
    
    public string? Description { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Price is required")]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}