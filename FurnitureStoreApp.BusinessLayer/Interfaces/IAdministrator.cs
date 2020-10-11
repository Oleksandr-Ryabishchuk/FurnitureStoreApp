using FurnitureStoreApp.DataAccessLayer.DTOs;
using FurnitureStoreApp.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStoreApp.BusinessLayer.Interfaces
{
    public interface IAdministrator
    {
        Task<Product> CreateFurniture(FurnitureDTO furnitureDTO);
        Task<IEnumerable<Product>> GetAllFurnitures();
        Task<Product> GetFurniture(Guid id);
        Task<Product> UpdateFurniture(Guid id, FurnitureDTO dto);
        Task DeleteFurniture(Guid id);
    }
}
