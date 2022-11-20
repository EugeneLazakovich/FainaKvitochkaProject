using FainaKvitochka_BL;
using FainaKvitochka_BL.Interfaces;
using FainaKvitochka_DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FainaKvitochkaProject.Controllers
{    
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _collectionService;
        public ItemController(IItemService collectionService)
        {
            _collectionService = collectionService;
        }

        [HttpGet("all")]
        public async Task<IEnumerable<Item>> GetAll()
        {
            return await _collectionService.GetAllItems();
        }

        [HttpGet("{id}")]
        public async Task<Item> GetById(Guid id)
        {
            return await _collectionService.GetByIdItem(id);
        }

        [Authorize(Roles = Role.Admin)]
        [HttpPost("add")]
        public async Task<IActionResult> Add(Item item)
        {
            try
            {
                var result = await _collectionService.AddItem(item);

                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize(Roles = Role.Admin)]
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, Item item)
        {
            try
            {
                item.Id = id;
                var result = await _collectionService.UpdateItem(item);

                return Ok();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize(Roles = Role.Admin)]
        [HttpGet("delete/{id}")]
        public async Task<bool> Delete(Guid id)
        {
            return await _collectionService.DeleteByIdItem(id);
        }
    }
}
