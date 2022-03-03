using System.ComponentModel.DataAnnotations.Schema;
using System.Security.AccessControl;

namespace TL.Catalog.Domain.Models;

public class Author
{
    [Column("name")]
    public string Name { get; set; }
    [Column("gender")]
    public char Gender { get; set; }
    public ICollection<Book> Books { get; set; }
}