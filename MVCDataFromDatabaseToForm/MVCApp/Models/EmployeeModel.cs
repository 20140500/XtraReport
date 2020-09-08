using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class EmployeeModel
    {
        [Display(Name ="Employee ID")]
        [Range(100000,999999,ErrorMessage ="Invalid Digit. 6 digits is required")]
        public int EmployeeId { get; set; }

        [Display(Name ="First Name")]
        [Required(ErrorMessage = "This field is required")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "This field is required")]
        public string LastName { get; set; }


        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage ="This field is required")]
        public string EmailAddress { get; set; }

        [Display(Name ="Confirm Email")]
        [Required(ErrorMessage ="This field is required")]
        [Compare("EmailAddress",ErrorMessage = "Email and Confirm Email Address doesn't match")]
        public string ConfirmEmail { get; set; }

        [Display(Name ="Password")]
        [DataType(DataType.Password)]
        [StringLength(10,MinimumLength = 5, ErrorMessage = "Invalid Character Length")]
        [Required(ErrorMessage ="This field is required")]
        public string Password { get; set; }

        [Display(Name ="Confirm Password")]
        [Required(ErrorMessage ="This field is required")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password and Confirm password doesn't match")]
        public string ConfirmPassowrd { get; set; }
    }
}