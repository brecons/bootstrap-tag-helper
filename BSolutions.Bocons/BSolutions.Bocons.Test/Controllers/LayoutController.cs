using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BSolutions.Bocons.Test.Controllers
{
    public class LayoutController : Controller
    {
        // GET: /<controller>/
        public IActionResult GridSystem()
        {
            return View();
        }

        public IActionResult MediaObject()
        {
            return View();
        }
    }
}
