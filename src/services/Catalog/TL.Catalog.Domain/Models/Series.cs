using System.ComponentModel.DataAnnotations.Schema;
using System.Security.AccessControl;

namespace TL.Catalog.Domain.Models;

public class Series
{
    [Column("quantity_own")]
    public int QuantityOwn { get; set; }
    [Column("quantity_total")]
    public int QuantityTotal { get; set; }
    [Column("modification_date")]
    public DateTime ModificationDate { get; set; }
    [Column("created_date")]
    public DateTime CreatedDate { get; set; }
    public virtual Author Author { get; set; } 
    public virtual Collection Collection { get; set; }
    public virtual ICollection<Book> Books { get; set; }
}