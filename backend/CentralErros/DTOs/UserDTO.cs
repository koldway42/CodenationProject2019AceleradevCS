﻿using System.ComponentModel.DataAnnotations;

namespace CentralErros.DTOs
{
    public class UserDTO
    {

        public int Id { get; set; }

        public string FullName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
