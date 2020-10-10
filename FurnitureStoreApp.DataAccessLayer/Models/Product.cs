using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureStoreApp.DataAccessLayer.Models
{
    public abstract class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool InStock { get; set; }

        public double Price { get; set; }
    }
}
