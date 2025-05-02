using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using W1417.Models;

namespace W1417.Controllers
{

	[ApiController]
	[Route("api/[controller]")]
	public class UsersController : Controller
	{
		private readonly SchoolDbContext _context;

		public UsersController(SchoolDbContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<User>>> GetUsers()
		{
			return await _context.Users.ToListAsync();
		}

		[HttpPost("PostUser")]
		public async Task<ActionResult> PostUser(User user)
		{
			if (user == null)
			{
				return BadRequest("Invalid");
			}


			user.PasswordHash = HashPassword(user.PasswordHash);
		
			_context.Users.Add(user);
			await _context.SaveChangesAsync();
			return Ok("Saved Successfully!");
		}
		public IActionResult Index()
		{
			return View();
		}

		public static string HashPassword(string PasswordHash)
		{
			using (SHA256 sha256Hash = SHA256.Create())
			{
				byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(PasswordHash));
				return Convert.ToBase64String(bytes);
			}
		}
		
		public static bool VerifyPassword(string PasswordHash)
		{
			// Hash the input password
			string hashedInputPassword = HashPassword(PasswordHash);

			// Compare the hashed input password with the stored password hash
			return hashedInputPassword == PasswordHash;
		}
	}
}
