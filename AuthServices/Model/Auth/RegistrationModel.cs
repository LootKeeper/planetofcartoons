using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthServices.Model.Auth
{
    public class RegistrationModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [Remote(action: "VerifyEmail", controller: "Auth")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmationPassword { get; set; }
    }
}
