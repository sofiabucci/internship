using MediatR;
using ProgrammersProjectLogin.Domain.Commands.Requests;
using ProgrammersProjectLogin.Domain.Commands.Responses;

namespace ProgrammersProjectLogin.Domain.Handlers
{
    public class LoginGetHandler : IRequestHandler<LoginGetRequest, LoginGetResponse>
    {
        public Task<LoginGetResponse> Handle(LoginGetRequest request, CancellationToken cancellationToken)
        {
            var result = new LoginGetResponse()
            {

            };

            return Task.FromResult(result);
        }
    }
}
