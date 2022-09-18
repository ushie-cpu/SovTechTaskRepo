using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SwapiChuckApi.Services;
using SwapiChuckApi.Services.IServices;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using SwapiChuckApi.Models.Dtos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwapiChuckApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SwapiController : ControllerBase
    {
        private ISwapiService _swapiService;

        public SwapiController(ISwapiService swapiService)
        {
            _swapiService = swapiService;
        }

        [HttpGet("people")]
        public async Task<IActionResult> Get(int page = 1)
        {
            var resp = await _swapiService.GetAllAsync(page);
            var result = JsonConvert.DeserializeObject<MetaDataDto<PersonDto>>(Convert.ToString(resp));
            return Ok(result);
        }

        [HttpGet("people/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var resp = await _swapiService.GetByIdAsync(id);
            var result = JsonConvert.DeserializeObject<PersonDto>(Convert.ToString(resp));
            return Ok(result);
        }
    }
}
