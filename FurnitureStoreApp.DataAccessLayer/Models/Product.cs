using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FurnitureStoreApp.DataAccessLayer.Models
{
    public abstract class Product
    {
        public Guid Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        [MaxLength(128)]
        public string Description { get; set; }

        public bool InStock { get; set; }

        [Required]
        public double Price { get; set; }
    }
}
