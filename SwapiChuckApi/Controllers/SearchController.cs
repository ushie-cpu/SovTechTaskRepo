using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SwapiChuckApi.Models.Dtos;
using SwapiChuckApi.Services;
using SwapiChuckApi.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwapiChuckApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchController : ControllerBase
    {
        private IChucksService _chucksService;
        private ISwapiService _swapiService;

        public SearchController(IChucksService chucksService, ISwapiService swapiService)
        {
            _chucksService = chucksService;
            _swapiService = swapiService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string query)
        {
            if(string.IsNullOrEmpty(query))
                return NotFound();

            var chuckRes = JsonConvert.DeserializeObject<ChuckSearchMetaDataDto<JokesDto>>(await _chucksService.Search(query));
            var swapiRes = JsonConvert.DeserializeObject<MetaDataDto<PersonDto>>(await _swapiService.Search(query));


            if(chuckRes.Total > 0)
            {
                var result = new SearchMetaDataDto<ChuckSearchMetaDataDto<JokesDto>>();
                result.api = "Chucksapi";
                result.result = chuckRes;
                return Ok(result);
            }

            if (swapiRes.count > 0)
            {
                var result = new SearchMetaDataDto<MetaDataDto<PersonDto>>();
                result.api = "Swapi";
                result.result = swapiRes;
                return Ok(result);
            }

            return NotFound();
        }

    }
}
 