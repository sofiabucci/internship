using MediatR;
using ProgrammersProject.CQRS.Domain.Commands.Requests;
using ProgrammersProject.CQRS.Domain.Commands.Response;

namespace ProgrammersProject.CQRS.Domain.Handlers
{
    public class GetLoginbyIdHandler : IRequestHandler<GetLoginbyIdRequest, GetLoginbyIdResponse>
    {
        public Task<GetLoginbyIdResponse> Handle(GetLoginbyIdRequest request, CancellationToken cancellationToken)
        {
            var result = new GetLoginbyIdResponse{ };

            return Task.FromResult(result);
        }
    }
}
