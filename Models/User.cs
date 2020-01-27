﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XtendersProject.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "User Name")]
        public string Username { get; set; }
        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
