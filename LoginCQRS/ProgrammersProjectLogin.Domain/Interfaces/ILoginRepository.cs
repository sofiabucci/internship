using ProgrammersProjectLogin.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersProjectLogin.Domain.Interfaces
{
    public interface ILoginRepository
    {
        Task<IEnumerable<Login>> GetAll();
        Task<bool> Add(Login login);
        Task<bool> Update(Guid id, Login login);
        Task<bool> Delete(Guid id);
    }
}
