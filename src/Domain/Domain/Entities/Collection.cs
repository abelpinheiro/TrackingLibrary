using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Repositories;

namespace Domain.Entities;

[Table("collection")]
public class Collection : IEntity
{
    [Key]
    public int Id { get; set; }
    
    [Column("type")]
    public string Type { get; set; }
    
    public virtual ICollection<Book> Books { get; set; }
}