using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("collection")]
public class Collection
{
    [Key]
    public int Id { get; set; }
    
    [Column("type")]
    public string Type { get; set; }
    
    public virtual ICollection<Book> Books { get; set; }
}