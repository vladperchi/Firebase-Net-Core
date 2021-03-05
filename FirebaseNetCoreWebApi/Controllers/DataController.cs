using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FirebaseNetCoreWebApi.Controllers
{
	
	[Route("api/[controller]")]
	[ApiController]
	public class DataController : Controller
	{
		[HttpGet("public")]
		public string Public()
		{
			return "This endpoint is public data.";
		}

		[Authorize]
		[HttpGet("protected")]
		public string Protected() 
		{ 
			return "This endpoint data is protected data";
		}
	}
}
