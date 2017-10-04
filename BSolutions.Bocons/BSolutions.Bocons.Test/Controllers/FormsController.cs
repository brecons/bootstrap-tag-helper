using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BSolutions.Bocons.Test.Models.Forms;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace BSolutions.Bocons.Test.Controllers
{
    public class FormsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Buttons()
        {
            return View();
        }

        public IActionResult Validation()
        {
            ValidationViewModel model = new ValidationViewModel();
            model.UserName = "tbremus";

            return View(model);
        }

        [HttpPost]
        public IActionResult Validation(ValidationViewModel model)
        {
            if (model.Interests.Count <= 0) ModelState.AddModelError("Interests", "You must choose at least one hobby.");
            if (model.BodyType == -1) ModelState.AddModelError("BodyType", "You must choose a body type.");
            if (!model.LicenseAgreed) ModelState.AddModelError("LicenseAgreed", "You must confirm the license terms.");
            ModelState.AddModelError("Email", "Willkürrlich");
            ModelState.AddModelError("Vita", "Willkürrlich");

            if (ModelState.IsValid)
            {
                return View();
            }

            return View(model);
        }

        public IActionResult Register()
        {
            return View(new RegisterViewModel());
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (model.Country == 0) ModelState.AddModelError("Country", "Please choose a country.");

            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            // On validation errors go back to view
            return View(model);
        }
    }
}
