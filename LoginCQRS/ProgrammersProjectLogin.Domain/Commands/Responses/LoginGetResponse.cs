using ProgrammersProjectLogin.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersProjectLogin.Domain.Commands.Responses
{
    public class LoginGetResponse
    {
        public IEnumerable<Login> logins { get; set; }
    }
}
