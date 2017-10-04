using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BSolutions.Bocons.Test.Models.Forms
{
    public class ValidationViewModel
    {
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Display(Name = "Email Address")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Name")]
        [Required]
        [RegularExpression("^[A-z]+$")]
        public string Name { get; set; }

        [Display(Name = "Gender")]
        public Gender Gender { get; set; }

        [Display(Name = "Birthday")]
        [Required]
        public DateTime Birthday { get; set; } = DateTime.Now;

        [Display(Name = "Vita")]
        [Required]
        public string Vita { get; set; }

        [Display(Name = "License agreed")]
        public bool LicenseAgreed { get; set; }

        [Display(Name = "Interests")]
        public List<SelectListItem> Interests { get; set; } = new List<SelectListItem>();

        [Display(Name = "Body Type")]
        public int BodyType { get; set; }

        public List<SelectListItem> BodyTypes { get; set; } = new List<SelectListItem>();

        public ValidationViewModel()
        {
            this.Interests.Add(new SelectListItem { Text = "Swimming", Value = "0" });
            this.Interests.Add(new SelectListItem { Text = "Running", Value = "1" });
            this.Interests.Add(new SelectListItem { Text = "Cycling", Value = "2" });
            this.Interests.Add(new SelectListItem { Text = "Climbing", Value = "3" });

            this.BodyTypes.Add(new SelectListItem { Text = "Please choose ...", Value = "-1" });
            this.BodyTypes.Add(new SelectListItem { Text = "Mesomorph", Value = "0" });
            this.BodyTypes.Add(new SelectListItem { Text = "Endomorph", Value = "1" });
            this.BodyTypes.Add(new SelectListItem { Text = "Ektomorph", Value = "2" });
        }
    }

    public enum Gender
    {
        [Display(Name = "Male")]
        Male,

        [Display(Name = "Female")]
        Female
    }
}
