﻿using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
    }
}
