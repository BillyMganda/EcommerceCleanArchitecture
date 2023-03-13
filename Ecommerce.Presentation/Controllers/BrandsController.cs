using Ecommerce.Application.Brand;
using Ecommerce.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Presentation.Controllers
{
    [Route("brands")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandsService _brandsService;
        public BrandsController(IBrandsService brandsService)
        {
            _brandsService = brandsService;
        }

        [HttpGet]
        public ActionResult<List<Brands>> GetBrands()
        {
            var brands = _brandsService.GetAllBrands();
            return Ok(brands);
        }
    }
}
