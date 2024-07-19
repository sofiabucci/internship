using Project.Domain.Models;
using Project.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Project.Domain.Interfaces.IBrand;

namespace Project.Infrastructure.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly ApplicationDataContext _context;

        public BrandRepository(ApplicationDataContext context)
        {
            _context = context;
        }
        public async Task<bool> Add(Brand brand)
        {
            _context.Brands.Add(brand);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(Guid id)
        {
            var brand = await _context.Brands.FindAsync(id);

            if (brand == null)
            {
                return false;
            }

            _context.Brands.Remove(brand);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Brand>> GetAll()
        {
            return await _context.Brands.ToListAsync();
        }

        public async Task<Brand> GetById(Guid id)
        {
            return await _context.Brands.FindAsync(id);
        }

        public async Task<bool> Update(Guid id, Brand request)
        {
            var brand = await _context.Brands.FindAsync(id);

            if (brand == null) return false;

            brand.Name = request.Name;

            _context.Brands.Update(brand);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}