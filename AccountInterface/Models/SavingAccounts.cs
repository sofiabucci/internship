using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountInterface.Interfaces;

namespace AccountInterface.Models
{
    internal class SavingAccounts : CAccount
    {

        public DateTime InterestDate { get; set; }
        public double Income { get; set; }

        public SavingAccounts(int branch, int number, string holder, double income)
        {
            Branch = branch;
            Number = number;
            Holder = holder;
            Balance = 0;
            InterestDate = DateTime.Now;
            Income = income;
        }

        public void InterestCredit(double percentage)
        {
            double creditAmount = Income * (percentage / 100);
            Balance += creditAmount;
            InterestDate = DateTime.Now;

        }
    }
}
