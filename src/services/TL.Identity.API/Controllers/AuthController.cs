using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TL.Identity.API.Models;

namespace TL.Identity.API.Controllers;

[ApiController]
[Route("api/identity")]
public class AuthController : Controller
{
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly UserManager<IdentityUser> _userManager;

    public AuthController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
    {
        _signInManager = signInManager;
        _userManager = userManager;
    }

    [HttpPost("new-account")]
    public async Task<ActionResult> RegisterUser([FromBody] UserDTO model)
    {
        if (!ModelState.IsValid) return BadRequest();

        var user = new IdentityUser
        {
            UserName = model.Email,
            Email = model.Email,
            EmailConfirmed = true
        };

        var result = await _userManager.CreateAsync(user, model.Password);
        if (!result.Succeeded)
        {
            return BadRequest(result.Errors);
        }

        await _signInManager.SignInAsync(user, false);

        return Ok();
    }

    [HttpPost("login")]
    public async Task<ActionResult> Login([FromBody] UserDTO userInfo)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState.Values.SelectMany(e => e.Errors));
        }

        var result = await _signInManager.PasswordSignInAsync(userInfo.Email,
            userInfo.Password, isPersistent: false, lockoutOnFailure: false);

        if (!result.Succeeded)
        {
            ModelState.AddModelError(string.Empty, "Invalid login...");
            return BadRequest(ModelState);
        }

        return Ok();
    }
}