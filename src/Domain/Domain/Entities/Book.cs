using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("book")]
public class Book
{
    [Key]
    [Column("Id")]
    public int Id { get; set; }
    [Column("title")]
    [Required]
    public string Title { get; set; }
    [Column("volume")]
    [Required]
    public int Volume { get; set; }
    [Column("created_date")]
    [Required]
    public DateTime CreatedDate { get; set; }
    public virtual Author Author { get; set; }
}