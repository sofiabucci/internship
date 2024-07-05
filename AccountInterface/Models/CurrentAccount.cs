using AccountInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInterface.Models
{
    internal class CurrentAccount : CAccount
    {
        public double CreditLimit { get; set; }

        public CurrentAccount(int branch, int number, string holder, double creditlimit)
        {
            Branch = branch;
            Number = number;
            Holder = holder;
            Balance = 0;
            CreditLimit = creditlimit;
        }

        public void InterestDiscount(double percentage)
        {
            double discount = Balance * ((100 - percentage) / 100);
            if (CreditLimit < discount)
            {
                throw new InvalidOperationException("Applying this interest discount would exceed the credit limit.");
            }
            else
            {
                Balance -= discount;
            }
        }
    }
}
