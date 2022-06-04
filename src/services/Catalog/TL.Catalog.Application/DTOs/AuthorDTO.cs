using System.ComponentModel.DataAnnotations;

namespace TL.Catalog.Application.DTOs;

public class AuthorDTO
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public char Gender { get; set; }
}