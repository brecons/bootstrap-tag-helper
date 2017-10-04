using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BSolutions.Bocons.Test.Models.Forms
{
    public class RegisterViewModel
    {
        [Display(Name = "Name")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Email Address")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Country")]
        public int Country { get; set; }

        public List<SelectListItem> Countries { get; set; } = new List<SelectListItem>();

        public RegisterViewModel()
        {
            this.Countries.Add(new SelectListItem { Value = "0", Text = "Choose a country" });
            this.Countries.Add(new SelectListItem { Value = "1", Text = "Germany" });
            this.Countries.Add(new SelectListItem { Value = "2", Text = "United States" });
            this.Countries.Add(new SelectListItem { Value = "3", Text = "United Kingdom" });
        }
    }
}
