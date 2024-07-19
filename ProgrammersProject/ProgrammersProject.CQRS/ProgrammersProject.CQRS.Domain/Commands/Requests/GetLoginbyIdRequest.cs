using MediatR;
using ProgrammersProject.CQRS.Domain.Commands.Response;

namespace ProgrammersProject.CQRS.Domain.Commands.Requests
{
    public class GetLoginbyIdRequest : IRequest<GetLoginbyIdResponse>
    {
        public Guid Id { get; set; }
    }
}
