using MediatR;
using ProgrammersProjectLogin.Domain.Commands.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersProjectLogin.Domain.Commands.Requests
{
    public class LoginPostRequest : IRequest<LoginPostResponse>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string TaxId { get; set; }

    }
}
