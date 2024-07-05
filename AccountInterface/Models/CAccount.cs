using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInterface.Interfaces
{
    public abstract class CAccount
    {
        public int Branch { get; set; }
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }

        public virtual void Deposit()
        {
            Console.WriteLine("Amount : ");
            double amount = double.Parse(Console.ReadLine());
            Balance += amount;
        }
        public virtual void Withdraw()
        {
            Console.WriteLine("Amount : ");
            double amount = double.Parse(Console.ReadLine());
            if (Balance < amount)
            {
                throw new InvalidOperationException("Insufficient funds for this withdrawal.");
            }
            else
            {
                Balance -= amount;
            }

        }
    }
}
