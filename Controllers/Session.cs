using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class Session : Controller
    {
        public string _Name
        {
            get
            {
                return HttpContext.Session.GetString("Name");

            }
            set
            {
                HttpContext.Session.SetString("Name", value);
            }
        }
        [HttpGet]
        public IActionResult SetName(string name)
        {
            System.Console.WriteLine("=== SetName ===");
            _Name = name;
            System.Console.WriteLine(name);
            System.Console.WriteLine("=== end SetName ===");

            return Ok(_Name);
        }
        [HttpGet]
        public IActionResult GetName()
        {
            System.Console.WriteLine("=== GetName ===");

            System.Console.WriteLine(_Name);
            System.Console.WriteLine("=== End GetName ===");

            return Ok(_Name);
        }
    }
}