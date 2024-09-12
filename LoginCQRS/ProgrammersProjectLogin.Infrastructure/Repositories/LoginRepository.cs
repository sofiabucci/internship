using Microsoft.EntityFrameworkCore;
using ProgrammersProjectLogin.Domain.Interfaces;
using ProgrammersProjectLogin.Domain.Models;
using ProgrammersProjectLogin.Infrastructure.Context;

namespace ProgrammersProjectLogin.Infrastructure.Repositories
{
    public class LoginRepository(ApplicationDataContext context) : ILoginRepository
    {
        private readonly ApplicationDataContext _context = context;

        public async Task<IEnumerable<Login>> GetAll()
        {
            return await _context.Logins.ToListAsync();
        }

        public async Task<bool> Add(Login login)
        {
            _context.Logins.AddAsync(login);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(Guid id)
        {
            var login = await _context.Logins.FindAsync(id);

            if (login == null)
            {
                return false;
            }

            _context.Logins.Remove(login);
            return await _context.SaveChangesAsync() > 0;
        }


        public async Task<bool> Update(Guid id, Login request)
        {
            var login = await _context.Logins.FindAsync(id);

            if (login == null) return false;

            login.Name = request.Name;
            login.Age = request.Age;
            login.TaxId = request.TaxId;

            _context.Logins.Update(login);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
