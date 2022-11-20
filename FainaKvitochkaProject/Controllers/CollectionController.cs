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
    public class CollectionController : ControllerBase
    {
        private readonly ICollectionBaseService _collectionService;
        public CollectionController(ICollectionBaseService collectionService)
        {
            _collectionService = collectionService;
        }

        [HttpGet("all")]
        public async Task<IEnumerable<CollectionBase>> GetAll()
        {
            return await _collectionService.GetAllCollections();
        }

        [HttpGet("{id}")]
        public async Task<CollectionBase> GetById(Guid id)
        {
            return await _collectionService.GetByIdCollection(id);
        }

        [Authorize(Roles = Role.Admin)]
        [HttpPost("add")]
        public async Task<IActionResult> Add(CollectionBase collection)
        {
            try
            {
                var result = await _collectionService.AddCollection(collection);

                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize(Roles = Role.Admin)]
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, CollectionBase collection)
        {
            try
            {
                collection.Id = id;
                var result = await _collectionService.UpdateCollection(collection);

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
            return await _collectionService.DeleteByIdCollection(id);
        }
    }
}
