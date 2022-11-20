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
    public class SizeController : ControllerBase
    {
        private readonly ISizeService _newsService;
        public SizeController(ISizeService newsService)
        {
            _newsService = newsService;
        }

        [HttpGet("all")]
        public async Task<IEnumerable<Size>> GetAll()
        {
            return await _newsService.GetAllSizes();
        }

        [HttpGet("{id}")]
        public async Task<Size> GetById(Guid id)
        {
            return await _newsService.GetByIdSize(id);
        }

        [Authorize(Roles = Role.Admin)]
        [HttpPost("add")]
        public async Task<IActionResult> Add(Size size)
        {
            try
            {
                var result = await _newsService.AddSize(size);

                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize(Roles = Role.Admin)]
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, Size size)
        {
            try
            {
                size.Id = id;
                var result = await _newsService.UpdateSize(size);

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
            return await _newsService.DeleteByIdSize(id);
        }
    }
}
