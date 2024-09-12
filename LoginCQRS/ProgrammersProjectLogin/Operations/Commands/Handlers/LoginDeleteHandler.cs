using MediatR;
using Microsoft.EntityFrameworkCore;
using ProgrammersProjectLogin.Domain.Commands.Requests;
using ProgrammersProjectLogin.Domain.Models;
using ProgrammersProjectLogin.Infrastructure.Context;

namespace ProgrammersProjectLogin.Domain.Handlers
{
    public class LoginDeleteHandler(ApplicationDataContext context) : IRequestHandler<LoginDeleteRequest, Login>
    {
        private readonly ApplicationDataContext _context = context;
        public async Task<Login> Handle(LoginDeleteRequest request, CancellationToken cancellationToken)
        {
            var login = await _context.Logins.Where(a => a.Id == request.Id).FirstOrDefaultAsync();
            _context.Remove(login);

            await _context.SaveChangesAsync();
            return login;
        }
    }
}
