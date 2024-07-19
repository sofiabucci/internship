using MediatR;
using ProgrammersProject.CQRS.Domain.Commands.Requests;
using ProgrammersProject.CQRS.Domain.Commands.Response;

namespace ProgrammersProject.CQRS.Domain.Handlers
{
    public class PutLoginHandler : IRequestHandler<PutLoginRequest, PutLoginResponse>
    {
        public Task<PutLoginResponse> Handle(PutLoginRequest request, CancellationToken cancellationToken)
        {
            var result = new PutLoginResponse
            {
                Success = true,
            };

            return Task.FromResult(result);
        }
    }
}
