using Ecommerce.Application.Brand;
using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastructure.Brand
{
    public class BrandsRepository : IBrandsRepository
    {
        private readonly EcommerceDataContext _context;
        public BrandsRepository(EcommerceDataContext context)
        {
            _context = context;
        }

        public async Task<Brands> DeleteBrand(int id)
        {
            var BrandToDelete = await _context.brands.FirstOrDefaultAsync(x => x.brand_id == id);
            _context.brands.Remove(BrandToDelete!);
            await _context.SaveChangesAsync();
            return null!;
        }

        public async Task<List<Brands>> GetAllBrands()
        {
            return await _context.brands.ToListAsync();
        }

        public async Task<Brands> GetBrandById(int id)
        {
            var brand = await _context.brands.FirstOrDefaultAsync(x => x.brand_id == id);
            return brand!;
        }

        public async Task<Brands> UpdateBrand(Brands brand)
        {
            var BrandToUpdate = await _context.brands.FirstOrDefaultAsync(x => x.brand_id == brand.brand_id);
            BrandToUpdate!.brand_name = brand.brand_name;
            await _context.SaveChangesAsync();
            return null!;
        }
    }
}
