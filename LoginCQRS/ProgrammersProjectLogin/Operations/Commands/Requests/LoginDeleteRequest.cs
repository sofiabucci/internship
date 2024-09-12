using MediatR;
using ProgrammersProjectLogin.Domain.Models;

namespace ProgrammersProjectLogin.Domain.Commands.Requests
{
    public class LoginDeleteRequest : IRequest<Login>
    {
        public Guid Id { get; set; }

    }
}
