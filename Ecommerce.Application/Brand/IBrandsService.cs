using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Brand
{
    public interface IBrandsService
    {
        Task<List<Brands>> GetAllBrands();        
        Task<Brands> GetBrandById(int id);
        Task<Brands> UpdateBrand(Brands brand);
        Task<Brands> DeleteBrand(int id);
    }
}
