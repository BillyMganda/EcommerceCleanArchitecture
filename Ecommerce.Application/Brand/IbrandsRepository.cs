using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Brand
{
    public interface IBrandsRepository
    {
        Task<IEnumerable<Brands>> GetAllBrandsAsync();
        Task<Brands> GetBrandByIdAsync(int id);
        Task<Brands> CreateBrandAsync(Brands brand);
        Task UpdateBrandAsync(Brands brand);
        Task DeleteBrandAsync(int id);
    }
}
