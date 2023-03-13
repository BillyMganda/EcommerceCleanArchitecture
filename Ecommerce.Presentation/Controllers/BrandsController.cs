using Ecommerce.Application.Brand;
using Ecommerce.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Presentation.Controllers
{
    [Route("brands")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandsService _service;
        public BrandsController(IBrandsService brandsService)
        {
            _service = brandsService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Brands>>> GetAllBrandsAsync()
        {
            var brands = await _service.GetAllBrandsAsync();
            return Ok(brands);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Brands>> GetBrandByIdAsync(int id)
        {
            var brand = await _service.GetBrandByIdAsync(id);
            if (brand == null)
            {
                return NotFound();
            }
            return Ok(brand);
        }

        [HttpPost]
        public async Task<ActionResult<Brands>> CreateBrandAsync(Brands brand)
        {
            var result = await _service.CreateBrandAsync(brand);
            return CreatedAtAction(nameof(GetBrandByIdAsync), new { id = result.brand_id }, result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateBrandAsync(int id, Brands brand)
        {
            if (id != brand.brand_id)
            {
                return BadRequest();
            }
            await _service.UpdateBrandAsync(brand);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteBrandAsync(int id)
        {
            await _service.DeleteBrandAsync(id);
            return NoContent();
        }
    }
}
