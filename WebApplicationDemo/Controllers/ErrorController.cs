using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationDemo.Controllers
{
	[Route("Error")]
	public class ErrorController
	{
		[Route("Support")]
		public string Support()
		{
			return "Content not Found. Contact Support.";
		}
	}
}
