using AutoMapper;
using FurnitureStoreApp.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureStoreApp.DataAccessLayer.Helpers
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Furniture, Product>();
        }
    }
}
