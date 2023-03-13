using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Brand
{
    public class BrandsService : IBrandsService
    {
        private readonly IBrandsRepository _repository;
        public BrandsService(IBrandsRepository brandRepository)
        {
            _repository = brandRepository;
        }

        public async Task<Brands> CreateBrandAsync(Brands brand)
        {
            return await _repository.CreateBrandAsync(brand);
        }

        public async Task DeleteBrandAsync(int id)
        {
            await _repository.DeleteBrandAsync(id);
        }

        public async Task<IEnumerable<Brands>> GetAllBrandsAsync()
        {
            return await _repository.GetAllBrandsAsync();
        }

        public async Task<Brands> GetBrandByIdAsync(int id)
        {
            return await _repository.GetBrandByIdAsync(id);
        }

        public async Task UpdateBrandAsync(Brands brand)
        {
            await _repository.UpdateBrandAsync(brand);
        }
    }
}
