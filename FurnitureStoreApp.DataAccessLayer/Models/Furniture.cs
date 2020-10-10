using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureStoreApp.DataAccessLayer.Models
{
    public class Furniture: Product
    {
        public bool IsUnique { get; set; }
        public int Width { get; set; }
        public int Lenth { get; set; }
        public int Height { get; set; }
    }
}
