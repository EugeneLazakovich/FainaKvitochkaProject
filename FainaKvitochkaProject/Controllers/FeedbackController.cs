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
    public class FeedbackController : ControllerBase
    {
        private readonly IFeedbackService _feedbackService;
        public FeedbackController(IFeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }

        [HttpGet("all")]
        public async Task<IEnumerable<Feedback>> GetAll()
        {
            return await _feedbackService.GetAllFeedbacks();
        }

        [HttpGet("{id}")]
        public async Task<Feedback> GetById(Guid id)
        {
            return await _feedbackService.GetByIdFeedback(id);
        }

        [Authorize(Roles = Role.Admin)]
        [HttpPost("add")]
        public async Task<IActionResult> Add(Feedback feedback)
        {
            try
            {
                var result = await _feedbackService.AddFeedback(feedback);

                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize(Roles = Role.Admin)]
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, Feedback feedback)
        {
            try
            {
                feedback.Id = id;
                var result = await _feedbackService.UpdateFeedback(feedback);

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
            return await _feedbackService.DeleteByIdFeedback(id);
        }
    }
}
