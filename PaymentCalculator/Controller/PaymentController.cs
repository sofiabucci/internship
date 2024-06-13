using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentCalculator.Controller
{
    using Model;
    public class PaymentController
    {
        public void Run(List<Employee> employees, List<Outsourced> outsourced)
        {

            Console.WriteLine("PAYMENTS:");
            foreach (Employee emp in employees)
            {
                emp.ShowNamePayment();
            }
            foreach (Outsourced outs in outsourced)
            {
                outs.ShowNamePayment();
            }

            Console.WriteLine("To end press any key...");
            Console.ReadLine();

        }
    }
}
