using MediatR;
using ProgrammersProject.CQRS.Domain.Commands.Requests;
using ProgrammersProject.CQRS.Domain.Commands.Response;

namespace ProgrammersProject.CQRS.Domain.Handlers
{
    public class DeleteLoginHandler : IRequestHandler<DeleteLoginRequest, DeleteLoginResponse>
    {
        public Task<DeleteLoginResponse> Handle(DeleteLoginRequest request, CancellationToken cancellationToken)
        {
            var result = new DeleteLoginResponse
            {
                Success = true,
            };

            return Task.FromResult(result);
        }
    }
}
