using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TwoWaySynonymsApi.Business.Dto;
using TwoWaySynonymsApi.Business.Meta;

namespace TwoWaySynonymsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SynonymController : ControllerBase
    {
        private readonly ISynonymBusiness _synonymBusiness;

        public SynonymController(ISynonymBusiness synonymBusiness)
        {
            _synonymBusiness = synonymBusiness;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            var result = await _synonymBusiness.GetAllAsync();
            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _synonymBusiness.GetByIdAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post(SynonymDto synonym)
        {
            var result = await _synonymBusiness.CreateAsync(synonym);
            if ((result?.Id ?? 0) != 0)
                return Created("", result.Id);
            return BadRequest();
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, SynonymDto synonym)
        {
            return Ok(await _synonymBusiness.UpdateAsync(id, synonym));
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _synonymBusiness.DeleteAsync(id);
            return Ok();
        }
    }
}