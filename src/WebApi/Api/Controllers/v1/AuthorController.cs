using Application.DataTransferObjects;
using Application.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.v1;

[ApiController]
[ApiVersion("1")]
[Route("api/v{version:apiVersion}/[controller]")]
public class AuthorController : ControllerBase
{
    private readonly IAuthorService _authorService;

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
        try
        {
            var result = await _authorService.CreateAsync(request);
            return Created("CreateAsync", new { Id = result });
        }
        catch (Exception err)
        {
            throw new BadHttpRequestException(err.Message);
        }
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        var result = await _authorService.GetAsync();
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> EditAsync()
    {
        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteAsync()
    {
        return NoContent();
    }
}