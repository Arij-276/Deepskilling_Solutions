using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;


[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginModel model)
    {
        if (IsValidUser(model))
        {
            var token = GenerateJwtToken(model.Username);
            return Ok(new { Token = token });
        }
        return Unauthorized();
    }

    private string GenerateJwtToken(string username)
    {
        var claims = new[]
        {
            new Claim(ClaimTypes.Name, username)
        };
        var key = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes("ThisIsASecretKeyForJwtToken"));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var token = new JwtSecurityToken(
            issuer: "MyAuthServer",
            audience: "MyApiUsers",
            claims: claims,
            expires: DateTime.Now.AddMinutes(60),
            signingCredentials: creds);
        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    public class SecureController : ControllerBase
{
    [HttpGet]
    [Authorize]
    public IActionResult GetSecret()
    {
        return Ok("This is a protected endpoint");
    }
}

    private bool IsValidUser(LoginModel model)
    {
        // Replace with real validation logic (e.g., check a database)
        return model.Username == "admin" && model.Password == "password";
    }
}
