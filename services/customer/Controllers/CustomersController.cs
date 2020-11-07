using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace catalog.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomersController : ControllerBase
	{
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] {"customer 1", "customer 2"};
		}
	}
}
