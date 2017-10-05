using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BSolutions.Bocons.Test.Controllers
{
    public class ContentController : Controller
    {
        // GET: /<controller>/
        public IActionResult Images()
        {
            return View();
        }

        public IActionResult Tables()
        {
            return View();
        }

        public IActionResult Figures()
        {
            return View();
        }
    }
}
