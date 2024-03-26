using DesignPatterns.DecoratorPattern.TestDbContextDirectory;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.DecoratorPattern.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestController : Controller
	{
		[HttpGet("Test")]
		public IActionResult Get()
		{
			using var contenx = new TestDbContext();
			contenx.Users.Add(new UserEntity()
			{
			
				Id=1,
				FullName="Yasemin Elvan"
			
			});
			
			return Ok();
		}
	}
}
