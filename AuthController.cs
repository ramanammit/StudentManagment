using Microsoft.AspNetCore.Mvc;

using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using W1417.Models;

namespace W1417.Controllers
{
	[ApiController]
	[Route("api/[controller]")]

	public class AuthController : Controller
	{
		private readonly SchoolDbContext _context;
		private readonly IConfiguration _config;

		public AuthController(SchoolDbContext context, IConfiguration config)
		{
			_context = context;
			_config = config;
		}

		[HttpPost("login")]

		public IActionResult Login([FromBody] Login login)
		{
			var user = _context.Users.FirstOrDefault(u => u.Email == login.Email && u.PasswordHash == login.Password);


			if (user == null)
			{
				return Unauthorized("Invalid username or password");
			}

			var tokenHandler = new JwtSecurityTokenHandler();
			var key = Encoding.UTF8.GetBytes(_config["Jwt:Key"]);
			var tokenDescriptor = new SecurityTokenDescriptor
			{
				Subject = new ClaimsIdentity(new[]
				{
				new Claim(ClaimTypes.Name, user.Username),
				new Claim(ClaimTypes.Role, user.Role.ToString())
			}),
				Expires = DateTime.UtcNow.AddHours(1),
				Issuer = _config["Jwt:Issuer"],
				Audience = _config["Jwt:Audience"],
				SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
			};

			var token = tokenHandler.CreateToken(tokenDescriptor);
			var tokenString = tokenHandler.WriteToken(token);

			return Ok(new { Token = tokenString });
		}
		public IActionResult Index()
		{
			return View();
		}

	}
}
