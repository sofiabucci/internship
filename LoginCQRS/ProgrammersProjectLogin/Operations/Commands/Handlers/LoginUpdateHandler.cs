using MediatR;
using ProgrammersProjectLogin.Domain.Commands.Requests;
using ProgrammersProjectLogin.Domain.Models;
using ProgrammersProjectLogin.Infrastructure.Context;

namespace ProgrammersProjectLogin.Domain.Handlers
{
    public class LoginUpdateHandler(ApplicationDataContext context) : IRequestHandler<LoginUpdateRequest, Login>
    {
        private readonly ApplicationDataContext _context = context;
        public async Task<Login> Handle(LoginUpdateRequest request, CancellationToken cancellationToken)
        {
            var login = _context.Logins.Where(a => a.Id == request.Id).FirstOrDefault();
            if (login == null)
            {
                return default;
            }
            else
            {
                login.Name = request.Name;
                login.Age = request.Age;
                login.TaxId = request.TaxId;

                await _context.SaveChangesAsync();
                return login;
            }
        }
    }
}
