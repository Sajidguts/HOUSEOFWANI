﻿using System.ComponentModel.DataAnnotations;

namespace HouseOfWani.Models
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
