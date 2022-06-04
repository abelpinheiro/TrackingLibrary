using Microsoft.AspNetCore.Mvc;

namespace TL.Catalog.API.Controllers;

[Route("api/[Controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    public BooksController()
    {
        
    }

    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        return null;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync()
    {
        return null;
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync()
    {
        return null;
    }

    [HttpPut]
    public async Task<IActionResult> PutAsync()
    {
        return null;
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteAsync()
    {
        return null;
    }
}