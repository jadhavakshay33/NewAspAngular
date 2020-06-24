﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewAspAngular.Models
{
    public class UserLoginModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string EmailId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public int MobileNumber { get; set; }
    }
}