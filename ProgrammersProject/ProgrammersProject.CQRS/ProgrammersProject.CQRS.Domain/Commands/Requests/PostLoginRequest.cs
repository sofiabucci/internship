using MediatR;
using ProgrammersProject.CQRS.Domain.Commands.Response;

namespace ProgrammersProject.CQRS.Domain.Commands.Requests
{
    public class PostLoginRequest : IRequest<PostLoginResponse>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string TaxId { get; set; }
    }
}
