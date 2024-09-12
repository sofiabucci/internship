using MediatR;
using ProgrammersProjectLogin.Domain.Commands.Requests;
using ProgrammersProjectLogin.Domain.Commands.Responses;

namespace ProgrammersProjectLogin.Domain.Handlers
{
    public class LoginPostHandler : IRequestHandler<LoginPostRequest, LoginPostResponse>
    {
        public Task<LoginPostResponse> Handle(LoginPostRequest request, CancellationToken cancellationToken)
        {
            var result = new LoginPostResponse
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
