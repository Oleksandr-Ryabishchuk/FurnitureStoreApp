using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FurnitureStoreApp.BusinessLayer.Interfaces;
using FurnitureStoreApp.DataAccessLayer.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureStoreApp.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IAdministrator _administrator;
        public ProductController(IAdministrator administrator)
        {
            _administrator = administrator;
        }

        [HttpGet]
        [Route("getAllFurnitures")]
        public async Task<IActionResult> GetAllFurnitures()
        {
            var result = await _administrator.GetAllFurnitures();

            return Ok(result);
        }

        [HttpGet("getFurnitureById/{id}")]       
        public async Task<IActionResult> GetFurniture(Guid id)
        {
            var result = await _administrator.GetFurniture(id);

            return Ok(result);
        }

        [HttpPost]
        [Route("addFurniture")]
        public async Task<IActionResult> AddFurniture(FurnitureDTO dto)
        {
            var result = await _administrator.CreateFurniture(dto);

            return Ok(new { result.Id, result.Name, result.Price, result.InStock });
        }

        [HttpPut("updateFurnitureById/{id}")]
        public async Task<IActionResult> UpdateFurniture(Guid id, FurnitureDTO dto)
        {
            var result = await _administrator.UpdateFurniture(id, dto);

            return Ok(result);
        }

        [HttpDelete("deleteFurnitureById/{id}")]
        public async Task<IActionResult> DeleteFurniture(Guid id)
        {
            await _administrator.DeleteFurniture(id);
            return Ok(await _administrator.GetAllFurnitures());
        }
    }
}