using MediatR;
using ProgrammersProjectLogin.Domain.Commands.Requests;
using ProgrammersProjectLogin.Domain.Models;
using ProgrammersProjectLogin.Infrastructure.Context;

namespace ProgrammersProjectLogin.Domain.Handlers
{
    public class LoginAddHandler(ApplicationDataContext context) : IRequestHandler<LoginAddRequest, Login>
    {
        private readonly ApplicationDataContext _context = context;
        public async Task<Login> Handle(LoginAddRequest request, CancellationToken cancellationToken)
        {
            var login = new Login()
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Age = request.Age,
                TaxId = request.TaxId,
            };

            _context.Logins.Add(login);
            await _context.SaveChangesAsync();
            return login;
        }
    }
}
