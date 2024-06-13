using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentCalculator.Controller
{
    using Model;

    public class OutsourcedController
    {
        public void Run(List<Outsourced> outsourcedList)
        {

            Outsourced outsourced = new Outsourced();

            Console.WriteLine("Employee - Id:");
            outsourced.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name: ");
            outsourced.Name = Console.ReadLine();

            Console.WriteLine("Hours: ");
            outsourced.Hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ValuePerHour: ");
            outsourced.ValuePerHour = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Additional Charge: ");
            outsourced.AddCharge = Convert.ToDouble(Console.ReadLine());

            outsourcedList.Add(outsourced);

        }
    }
}
