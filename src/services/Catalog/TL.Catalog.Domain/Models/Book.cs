using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TL.Catalog.Domain.Models;

public class Book
{
    [Key]
    [Column("Id")]
    public int Id { get; set; }
    [Column("title")]
    public string Title { get; set; }
    [Column("volume")]
    public string Volume { get; set; }
    [Column("created_date")]
    public DateTime CreatedDate { get; set; }
    public virtual Author Author { get; set; }
    /*public virtual Seller Seller { get; set; }
    public virtual Series Series { get; set; }
    public virtual Collection Collection { get; set; }*/
}