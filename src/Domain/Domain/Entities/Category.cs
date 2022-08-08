using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Repositories;

namespace Domain.Entities;

[Table("category")]
public class Category : IEntity
{
    [Key]
    public int Id { get; set; }

    [Column("genre")]
    public string Genre { get; set; }
    
    public virtual ICollection<Book> Books { get; set; }
    public virtual ICollection<Series> Series { get; set; }
}