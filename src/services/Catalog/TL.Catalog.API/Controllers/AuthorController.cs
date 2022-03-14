using Microsoft.AspNetCore.Mvc;
using TL.Catalog.Application.Interfaces;
using TL.Catalog.Application.Services;

namespace TL.Catalog.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthorsController : ControllerBase
{
    public IAuthorService _authorService;
    
    public AuthorsController(IAuthorService authorService)
    {
        _authorService = authorService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        return Ok(_authorService.GetAllAsync());
    }
}