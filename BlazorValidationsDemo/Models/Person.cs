﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorValidationsDemo.Models
{
    public class Person
    {
        [Required]
        public string FirstName { get; set; } = "Amarjeet";
        [Required]
        public string LastName { get; set; }
        [Required]
        public int? Age { get; set; }
    }
}