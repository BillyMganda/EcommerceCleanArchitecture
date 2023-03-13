using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Brand
{
    public class BrandsService : IBrandsService
    {
        private readonly IbrandsRepository _brandRepository;
        public BrandsService(IbrandsRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }
        Task<List<Brands>> IBrandsService.GetAllBrands()
        {
            return _brandRepository.GetAllBrands();
        }

        Task<Brands> IBrandsService.GetBrandById(int id)
        {
            return _brandRepository.GetBrandById(id);
        }

        Task<Brands> IBrandsService.UpdateBrand(Brands brand)
        {
            return _brandRepository.UpdateBrand(brand);
        }

        Task<Brands> IBrandsService.DeleteBrand(int id)
        {
            return _brandRepository.DeleteBrand(id);
        }
    }
}
