using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("author")]
public class Author
{
    [Key] 
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; }
    
    [Column("gender")] 
    public char Gender { get; set; }
    
    public virtual ICollection<Book> Books { get; set; }
    public virtual ICollection<Series> Series { get; set; }
}