using Project.Domain.Models;
using Project.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Project.Domain.Interfaces.ICategory;

namespace Project.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDataContext _context;

        public CategoryRepository(ApplicationDataContext context)
        {
            _context = context;
        }
        public async Task<bool> Add(Category category)
        {
            _context.Categories.Add(category);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(Guid id)
        {
            var category = await _context.Categories.FindAsync(id);

            if (category == null)
            {
                return false;
            }

            _context.Categories.Remove(category);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetById(Guid id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public async Task<bool> Update(Guid id, Category request)
        {
            var category = await _context.Categories.FindAsync(id);

            if (category == null) return false;

            category.Name = request.Name;

            _context.Categories.Update(category);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}