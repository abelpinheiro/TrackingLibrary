using Application.DataTransferObjects;
using Application.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.v1;

[ApiController]
[ApiVersion("1")]
[Route("api/v{version:apiVersion}/[controller]")]
public class AuthorController : ControllerBase
{
    private IAuthorService _authorService;

    public AuthorController(IAuthorService authorService)
    {
        _authorService = authorService;
    }

    ///<summary>
    /// Insert a new Author
    /// </summary>
    /// <remarks>
    /// Creates a new Author to be inserted in the database.
    /// </remarks>
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] AuthorPostRequest request)
    {
        await _authorService.CreateAsync(request);
        //TODO ver se retorna createdAtAction ou statuscodes
        return CreatedAtRoute("GetAsync", new {id = 2}, 2);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        List<string> data = new List<string>()
        {
            "oi", "deu", "bom"
        };
        return Ok(data);
    }
}