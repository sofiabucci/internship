using Project.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Interfaces.IBrand
{
    public interface IBrandRepository
    {
        Task<IEnumerable<Brand>> GetAll();
        Task<Brand> GetById(Guid id);
        Task<bool> Add(Brand brand);
        Task<bool> Update(Guid id, Brand brand);
        Task<bool> Delete(Guid id);
    }
}
