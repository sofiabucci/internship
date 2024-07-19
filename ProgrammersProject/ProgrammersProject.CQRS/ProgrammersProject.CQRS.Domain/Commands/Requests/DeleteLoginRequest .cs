using MediatR;
using ProgrammersProject.CQRS.Domain.Commands.Response;

namespace ProgrammersProject.CQRS.Domain.Commands.Requests
{
    public class DeleteLoginRequest : IRequest<DeleteLoginResponse>
    {
        public Guid Id { get; set; }
    }
}
