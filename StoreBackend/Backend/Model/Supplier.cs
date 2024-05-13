using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Model;

[Table("suppliers")]
public class Supplier {
    [Required]
    public required string Id { get; set; }
    public required string Name { get; set; }
    public required string Address { get; set; }
}