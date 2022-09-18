using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SwapiChuckApi.Models;
using SwapiChuckApi.Models.Dtos;
using SwapiChuckApi.Services.IServices;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwapiChuckApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ChuckController : ControllerBase
    {
        private readonly IChucksService _chucksService;

        public ChuckController(IChucksService chucksService)
        {
            _chucksService = chucksService;
        }

        [HttpGet("categories")]
        public async Task<IActionResult> Get()
        {
            var resp = await _chucksService.GetAllAsync();
            var result = JsonConvert.DeserializeObject<List<string>>(Convert.ToString(resp));
            return Ok(result);
        }

        [HttpGet("random")]
        public async Task<IActionResult> Get(string category)
        {
            var list = new JokesDto();
            var res = await _chucksService.GetByCategoryAsync(category);
            list = JsonConvert.DeserializeObject<JokesDto>(Convert.ToString(res));
            if(res == null)
            {
                return NotFound();
            }
            return Ok(list);
        }
    }
}
