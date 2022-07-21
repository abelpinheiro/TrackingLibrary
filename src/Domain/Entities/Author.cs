using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.AccessControl;

namespace Domain.Entities
{
    [Table("author")]
    public class Author
    {
        [Key] 
        public int Id { get; set; }

        [Column("name")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Column("gender")] 
        public char Gender { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}