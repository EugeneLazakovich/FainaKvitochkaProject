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
    public class FormController : ControllerBase
    {
        private readonly IFormService _formService;
        public FormController(IFormService formService)
        {
            _formService = formService;
        }

        [HttpGet("all")]
        public async Task<IEnumerable<Form>> GetAll()
        {
            return await _formService.GetAllForms();
        }

        [HttpGet("{id}")]
        public async Task<Form> GetById(Guid id)
        {
            return await _formService.GetByIdForm(id);
        }

        [Authorize(Roles = Role.Admin)]
        [HttpPost("add")]
        public async Task<IActionResult> Add(Form form)
        {
            try
            {
                var result = await _formService.AddForm(form);

                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize(Roles = Role.Admin)]
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, Form form)
        {
            try
            {
                form.Id = id;
                var result = await _formService.UpdateForm(form);

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
            return await _formService.DeleteByIdForm(id);
        }
    }
}
