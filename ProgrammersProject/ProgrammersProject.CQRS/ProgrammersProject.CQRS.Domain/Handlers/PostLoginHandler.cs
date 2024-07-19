using MediatR;
using ProgrammersProject.CQRS.Domain.Commands.Requests;
using ProgrammersProject.CQRS.Domain.Commands.Response;

namespace ProgrammersProject.CQRS.Domain.Handlers
{
    public class PostLoginHandler : IRequestHandler<PostLoginRequest, PostLoginResponse>
    {
        public Task<PostLoginResponse> Handle(PostLoginRequest request, CancellationToken cancellationToken)
        {
            var result = new PostLoginResponse
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Age = request.Age,
                TaxId = request.TaxId,
            };

            return Task.FromResult(result);
        }
    }
}
