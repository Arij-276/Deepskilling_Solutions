using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


public class User
{
   public required string Username { get; set; }
public required string Password { get; set; }

}
