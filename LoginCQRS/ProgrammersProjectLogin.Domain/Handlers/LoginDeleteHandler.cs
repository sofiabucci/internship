using MediatR;
using ProgrammersProjectLogin.Domain.Commands.Requests;
using ProgrammersProjectLogin.Domain.Commands.Responses;

namespace ProgrammersProjectLogin.Domain.Handlers
{
    public class LoginDeleteHandler : IRequestHandler<LoginDeleteRequest, LoginDeleteResponse>
    {
        public Task<LoginDeleteResponse> Handle(LoginDeleteRequest request, CancellationToken cancellationToken)
        {
            var result = new LoginDeleteResponse
            {
                Sucess = true,
            };

            return Task.FromResult(result);
        }
    }
}
