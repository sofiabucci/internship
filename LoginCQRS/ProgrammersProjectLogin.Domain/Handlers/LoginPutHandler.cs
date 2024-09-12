using MediatR;
using ProgrammersProjectLogin.Domain.Commands.Requests;
using ProgrammersProjectLogin.Domain.Commands.Responses;

namespace ProgrammersProjectLogin.Domain.Handlers
{
    public class LoginPutHandler : IRequestHandler<LoginPutRequest, LoginPutResponse>
    {
        public Task<LoginPutResponse> Handle(LoginPutRequest request, CancellationToken cancellationToken)
        {
            var result = new LoginPutResponse
            {
                Sucess = true
            };

            return Task.FromResult(result);
        }
    }
}
