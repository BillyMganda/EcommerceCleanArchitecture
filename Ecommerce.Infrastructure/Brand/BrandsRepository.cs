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

        public async Task<Brands> CreateBrandAsync(Brands brand)
        {
            var result = await _context.brands.AddAsync(brand);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteBrandAsync(int id)
        {
            var brand = await GetBrandByIdAsync(id);
            if (brand != null)
            {
                _context.brands.Remove(brand);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Brands>> GetAllBrandsAsync()
        {
            return await _context.brands.ToListAsync();
        }

        public async Task<Brands> GetBrandByIdAsync(int id)
        {
            var result = await _context.brands.FindAsync(id);
            return result!;
        }

        public async Task UpdateBrandAsync(Brands brand)
        {
            _context.Entry(brand).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
