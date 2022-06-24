using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("series")]
public class Series
{
    [Key]
    public int Id { get; set; }
    
    [Column("quantity_own")]
    public int QuantityOwn { get; set; }
    
    [Column("quantity_total")]
    public int QuantityTotal { get; set; }
    
    [Column("modification_date")]
    public DateTime ModificationDate { get; set; }
    
    [Column("created_date")]
    public DateTime CreatedDate { get; set; }
    
    public virtual ICollection<Book> Books { get; set; }
    public virtual ICollection<Author> Authors { get; set; }
    public virtual ICollection<Category> Categories { get; set; }
}