using System.ComponentModel.DataAnnotations;

namespace SupplyHub.Web.Models;

public class Supplier
{
    public int Id { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; } = String.Empty;

    [EmailAddress]
    [StringLength(200)]
    public string? Email { get; set; }

    [Phone]
    [StringLength(20)]
    public string? Phone { get; set; }

    public ICollection<Product> Products { get; set; } = new List<Product>();
}
