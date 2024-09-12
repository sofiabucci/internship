using MediatR;
using ProgrammersProjectLogin.Domain.Models;

namespace ProgrammersProjectLogin.Domain.Commands.Requests
{
    public class LoginAddRequest : IRequest<Login>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string TaxId { get; set; }

    }
}
