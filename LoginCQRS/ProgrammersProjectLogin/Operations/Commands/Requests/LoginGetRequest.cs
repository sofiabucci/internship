using MediatR;
using ProgrammersProjectLogin.Domain.Models;

namespace ProgrammersProjectLogin.Domain.Commands.Requests
{
    public class LoginGetRequest : IRequest<IEnumerable<Login>>
    {
    }
}
