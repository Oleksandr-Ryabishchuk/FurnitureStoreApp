using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureStoreApp.DataAccessLayer.DTOs
{
    public class FurnitureDTO
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public bool InStock { get; set; }

        public double Price { get; set; }

        public bool IsUnique { get; set; }

        public int Width { get; set; }

        public int Lenth { get; set; }

        public int Height { get; set; }
    }
}
