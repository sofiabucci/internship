using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersProject.CQRS.Domain.Entities
{
    public class Login
    {
        public Login (string name, int age, string taxid)
        {
            Id = Guid.NewGuid();
            Name = name;
            Age = age;
            TaxId = taxid;
        }

        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string TaxId { get; private set; }
    }
}
