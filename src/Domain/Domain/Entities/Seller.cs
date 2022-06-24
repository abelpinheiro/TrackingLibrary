using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("seller")]
public class Seller
{
    [Key]
    public int Id { get; set; }

    public string Store { get; set; }

    public decimal Price { get; set; }

    public string Isbn { get; set; }
    public virtual Book Book { get; set; }
}