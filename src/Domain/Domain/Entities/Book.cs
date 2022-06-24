using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("book")]
public class Book
{
    [Key]
    public int Id { get; set; }
    
    [Column("title")]
    public string Title { get; set; }
    
    [Column("volume")]
    public int Volume { get; set; }
    
    [Column("created_date")]
    public DateTime CreatedDate { get; set; }
    
    public int SeriesId { get; set; }
    
    public int CollectionId { get; set; }
    
    public virtual ICollection<Author> Authors { get; set; }
    public virtual ICollection<Category> Categories { get; set; }
    public virtual Seller Seller { get; set; }
    public virtual Series Series { get; set; }
    public virtual Collection Collection { get; set; }
}