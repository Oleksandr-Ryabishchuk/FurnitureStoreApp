using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FurnitureStoreApp.DataAccessLayer.Models
{
    public class Furniture: Product
    {
        public bool IsUnique { get; set; }
        [Required]
        public int Width { get; set; }
        [Required]
        public int Lenth { get; set; }
        [Required]
        public int Height { get; set; }
    }
}
