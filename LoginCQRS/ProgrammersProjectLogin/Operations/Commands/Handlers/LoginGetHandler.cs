using MediatR;
using Microsoft.EntityFrameworkCore;
using ProgrammersProjectLogin.Domain.Commands.Requests;
using ProgrammersProjectLogin.Domain.Models;
using ProgrammersProjectLogin.Infrastructure.Context;

namespace ProgrammersProjectLogin.Domain.Handlers
{
    public class LoginGetHandler(ApplicationDataContext context) : IRequestHandler<LoginGetRequest, IEnumerable<Login>>
    {
        private readonly ApplicationDataContext _context = context;
        public async Task<IEnumerable<Login>> Handle(LoginGetRequest request, CancellationToken cancellationToken)
        {
            return await _context.Logins.ToListAsync();
        }
    }
}
