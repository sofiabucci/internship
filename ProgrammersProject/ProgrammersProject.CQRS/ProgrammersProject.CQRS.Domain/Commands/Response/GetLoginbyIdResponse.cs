using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersProject.CQRS.Domain.Commands.Response
{
    public class GetLoginbyIdResponse
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Age { get; set; }
        public string TaxId { get; set; }
    }
}
