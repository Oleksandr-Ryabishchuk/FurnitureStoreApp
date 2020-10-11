using AutoMapper;
using FurnitureStoreApp.BusinessLayer.Interfaces;
using FurnitureStoreApp.DataAccessLayer.DTOs;
using FurnitureStoreApp.DataAccessLayer.Models;
using FurnitureStoreApp.DataAccessLayer.Repository;
using FurnitureStoreApp.DataAccessLayer.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStoreApp.BusinessLayer.Managers
{
    public class Administrator : IAdministrator
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public Administrator(IUnitOfWork unitOfWork,
                             IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<Product> CreateFurniture(FurnitureDTO dto)
        {
            var newFurniture = new Furniture
            {
                Name = dto.Name,
                Description = dto.Description,
                InStock = dto.InStock,
                Price = dto.Price,
                IsUnique = dto.IsUnique,
                Lenth = dto.Lenth,
                Width = dto.Width,
                Height = dto.Height
            };

            await _unitOfWork.GetRepository<Furniture>().Insert(newFurniture);
            await _unitOfWork.SaveAsync();
            _unitOfWork.Dispose();
            return newFurniture;
        } 

        public async Task<IEnumerable<Product>> GetAllFurnitures()
        {
            var furnitures = await _unitOfWork.GetRepository<Furniture>().GetAll();

            var result = _mapper.Map<IEnumerable<Product>>(furnitures);

            _unitOfWork.Dispose();

            return result;
        }

        public async Task<Product> GetFurniture(Guid id)
        {
            var furniture = await _unitOfWork.GetRepository<Furniture>().GetById(id);

            _unitOfWork.Dispose();

            return furniture;
        }

        public async Task<Product> UpdateFurniture(Guid id, FurnitureDTO dto)
        {
            var repo = _unitOfWork.GetRepository<Furniture>();

            var furnitureToUpdate = await repo.GetById(id);

            furnitureToUpdate.Name = dto.Name;
            furnitureToUpdate.Description = dto.Description;
            furnitureToUpdate.InStock = dto.InStock;
            furnitureToUpdate.Price = dto.Price;
            furnitureToUpdate.IsUnique = dto.IsUnique;
            furnitureToUpdate.Lenth = dto.Lenth;
            furnitureToUpdate.Width = dto.Width;
            furnitureToUpdate.Height = dto.Height;           

            repo.Update(furnitureToUpdate);

            await _unitOfWork.SaveAsync();
            _unitOfWork.Dispose();

            return furnitureToUpdate;
        }

        public async Task DeleteFurniture(Guid id)
        {
            await _unitOfWork.GetRepository<Furniture>().Delete(id);
            await _unitOfWork.SaveAsync();
            _unitOfWork.Dispose();
        }
    }
}
