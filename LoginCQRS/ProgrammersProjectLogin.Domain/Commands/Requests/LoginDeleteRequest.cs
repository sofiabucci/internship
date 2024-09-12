using MediatR;
using ProgrammersProjectLogin.Domain.Commands.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersProjectLogin.Domain.Commands.Requests
{
    public class LoginDeleteRequest : IRequest<LoginDeleteResponse>
    {
        public Guid Id { get; set; }

    }
}
