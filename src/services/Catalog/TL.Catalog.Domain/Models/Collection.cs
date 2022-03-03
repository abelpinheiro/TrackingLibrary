namespace TL.Catalog.Domain.Models;

public class Collection
{
    public string Type { get; set; }
    public virtual Category Category { get; set; }
    public virtual ICollection<Book> Books { get; set; }
    public virtual ICollection<Series> Series { get; set; }
}