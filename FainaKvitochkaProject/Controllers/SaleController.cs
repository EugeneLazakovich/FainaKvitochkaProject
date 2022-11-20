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
    public class SaleController : ControllerBase
    {
        private readonly ISaleService _newsService;
        public SaleController(ISaleService newsService)
        {
            _newsService = newsService;
        }

        [Authorize(Roles = Role.Admin)]
        [HttpGet("all")]
        public async Task<IEnumerable<Sale>> GetAll()
        {
            return await _newsService.GetAllSales();
        }

        [Authorize(Roles = Role.Admin)]
        [HttpGet("{id}")]
        public async Task<Sale> GetById(Guid id)
        {
            return await _newsService.GetByIdSale(id);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(Sale keyWord)
        {
            try
            {
                var result = await _newsService.AddSale(keyWord);

                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize(Roles = Role.Admin)]
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, Sale keyWord)
        {
            try
            {
                keyWord.Id = id;
                var result = await _newsService.UpdateSale(keyWord);

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
            return await _newsService.DeleteByIdSale(id);
        }
    }
}
