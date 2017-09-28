using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace collectionManager.Controllers
{
    public class HelloWorldController : Controller
    {
		//
		// GET: /HelloWorld
		public IActionResult Index()
        {
			//  View defaults to HelloWorld/Index.cshtml
			return View();
        }

		//
		// GET: /HelloWorld/SomethingElse/
		public string SomethingElse(string someVal, int id)
		{
			//  Oldschool way
			//return HtmlEncoder.Default.Encode("Oldschool " + someVal + " " + id.ToString());
			//  Interpolated with $
			return HtmlEncoder.Default.Encode($"Something has this: {someVal}, and id = {id}");
        }

		public IActionResult ViewTest(string name , int repeat)
		{

			ViewData["name"] = name;
			ViewData["repeat"] = repeat;


			return View();
		}


    }
}
