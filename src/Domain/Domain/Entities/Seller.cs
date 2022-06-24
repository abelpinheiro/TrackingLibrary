using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("seller")]
public class Seller
{
    [Key]
    public string IsbnId { get; set; }

    public string Store { get; set; }

    public decimal Price { get; set; }

    public virtual Book Book { get; set; }
}