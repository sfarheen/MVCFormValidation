using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCValidationExample.Models
{
    public class Register
    {
        [Required(ErrorMessage = "FirstName is Required")]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required(ErrorMessage = "Age is Required")]
        [Range(20, 40, ErrorMessage = "Age must be between 20 and 40")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Not a valid format.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [DataType(DataType.Password)]
        [StringLength(10, ErrorMessage = "Password must be less than 10 letters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "ConfirmPassword is Required")]
        [DataType(DataType.Password)]
        [StringLength(10, ErrorMessage = "Password must be less than 10 letters")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}