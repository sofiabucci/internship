using Project.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Interfaces.ICategory
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAll();
        Task<Category> GetById(Guid id);
        Task<bool> Add(Category category);
        Task<bool> Update(Guid id, Category category);
        Task<bool> Delete(Guid id);
    }
}
