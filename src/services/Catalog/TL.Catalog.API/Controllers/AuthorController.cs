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

    /// <summary>
    /// Insert a new Author in the database.
    /// </summary>
    /// <param name="authorDTO">An author</param>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] AuthorDTO authorDTO)
    {
        var authorId = await _authorService.CreateAsync(authorDTO);

        return Created("GetAuthor", authorId);
    }

    /// <summary>
    /// Get an author given its Id.
    /// </summary>
    /// <param name="Id">Id of an author</param>
    /// <returns></returns>
    [HttpGet("{Id}", Name = "GetAuthor")]
    public async Task<IActionResult> GetByIdAsync(int Id)
    {
        return Ok(await _authorService.GetByIdAsync(Id));
    }

    /// <summary>
    /// Deletes multiples authors given a list of ids.
    /// </summary>
    /// <param name="Id"></param>
    /// <returns></returns>
    /*[HttpDelete]
    public async Task<IActionResult> DeleteAsync(int Id)
    {
        return null;
    }*/

    /// <summary>
    /// Deletes an author given its Id.
    /// </summary>
    /// <param name="Id"></param>
    /// <returns></returns>
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteByIdAsync(int id)
    {
        await _authorService.DeleteByIdAsync(id);
        return NoContent();
    }

    /// <summary>
    /// Updates information about a author.
    /// </summary>
    /// <param name="author"></param>
    /// <returns></returns>
    [HttpPut]
    public async Task<IActionResult> EditAsync(AuthorDTO author)
    {
        await _authorService.EditAsync(author);
        return Ok();
    }
}