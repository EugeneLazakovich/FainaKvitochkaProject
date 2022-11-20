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
    public class KeyWordController : ControllerBase
    {
        private readonly IKeyWordService _keyWordService;
        public KeyWordController(IKeyWordService keyWordService)
        {
            _keyWordService = keyWordService;
        }

        [HttpGet("all")]
        public async Task<IEnumerable<KeyWord>> GetAll()
        {
            return await _keyWordService.GetAllKeyWords();
        }

        [HttpGet("{id}")]
        public async Task<KeyWord> GetById(Guid id)
        {
            return await _keyWordService.GetByIdKeyWord(id);
        }

        [Authorize(Roles = Role.Admin)]
        [HttpPost("add")]
        public async Task<IActionResult> Add(KeyWord keyWord)
        {
            try
            {
                var result = await _keyWordService.AddKeyWord(keyWord);

                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize(Roles = Role.Admin)]
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, KeyWord keyWord)
        {
            try
            {
                keyWord.Id = id;
                var result = await _keyWordService.UpdateKeyWord(keyWord);

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
            return await _keyWordService.DeleteByIdKeyWord(id);
        }
    }
}
