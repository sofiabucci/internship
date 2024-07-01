using AccountInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInterface.Models
{
    internal class Account
    {
        private readonly CAccount _account;
        public Account(CAccount account)
        {
            _account = account;
        }

    }
}
