using PaymentCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentCalculator.Controller
{
    using Model;

    public class EmployeeController
    {
        public void Run(List<Employee> employeeList)
        {

            Employee employee = new Employee();

            Console.WriteLine("Employee - Id:");
            employee.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name: ");
            employee.Name = Console.ReadLine();

            Console.WriteLine("Hours: ");
            employee.Hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ValuePerHour: ");
            employee.ValuePerHour = Convert.ToDouble(Console.ReadLine());

            employeeList.Add(employee);

        }
    }
}
