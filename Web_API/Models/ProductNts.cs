﻿using System.ComponentModel.DataAnnotations;

namespace Web_API.Models
{
    public class ProductNts
    {
        [Required]
        public string Name { get; set; } = "";
        [Required]
        public string Brand { get; set; } = "";
        [Required]
        public string Category { get; set; } = "";
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Description { get; set; } = "";
    }
}
