using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersProjectLogin.Domain.Commands.Responses
{
    public class LoginPostResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string TaxId { get; set; }
    }
}
