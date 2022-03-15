using Microsoft.AspNetCore.Mvc;
using TL.Catalog.Application.DTOs;
using TL.Catalog.Application.Interfaces;
using TL.Catalog.Application.Services;

namespace TL.Catalog.API.Controllers;

[ApiVersion("1.0")]
[Produces("application/json")]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiController]
public class AuthorsController : ControllerBase
{
    public IAuthorService _authorService;
    
    public AuthorsController(IAuthorService authorService)
    {
        _authorService = authorService;
    }
    
    /// <summary>
    /// Get all authors
    /// </summary>
    /// <returns>Author object</returns>
    [HttpGet]
    [ProducesResponseType(typeof(List<AuthorDTO>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAsync()
    {
        return Ok(_authorService.GetAllAsync());
    }
}