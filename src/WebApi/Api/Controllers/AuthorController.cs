using Application.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthorController : ControllerBase
{
    private readonly IAuthorService _authorService;
    
    public AuthorController(IAuthorService authorService)
    {
        _authorService = authorService;
    }
    
    [HttpPost]
    public NoContentResult CreateAsync()
    {
        return NoContent();
        //await _authorService.CreateAsync();
    }
}