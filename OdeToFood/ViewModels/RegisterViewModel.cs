﻿using System.ComponentModel.DataAnnotations;

namespace OdeToFood.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [MaxLength(256)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

    }
}
