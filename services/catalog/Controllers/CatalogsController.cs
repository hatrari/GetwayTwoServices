using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace catalog.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CatalogsController : ControllerBase
	{
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] {"catalog 1", "catalog 2"};
		}
	}
}
