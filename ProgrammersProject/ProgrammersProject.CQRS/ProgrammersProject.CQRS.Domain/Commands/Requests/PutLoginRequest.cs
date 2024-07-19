using MediatR;
using ProgrammersProject.CQRS.Domain.Commands.Response;

namespace ProgrammersProject.CQRS.Domain.Commands.Requests
{
    public class PutLoginRequest : IRequest<PutLoginResponse>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string TaxId { get; set; }
    }
}
