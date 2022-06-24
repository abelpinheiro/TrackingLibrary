using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("category")]
public class Category
{
    [Key]
    public int Id { get; set; }

    [Column("genre")]
    public string Genre { get; set; }
    
    public virtual ICollection<Book> Books { get; set; }
    public virtual ICollection<Series> Series { get; set; }
}