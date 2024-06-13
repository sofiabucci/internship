using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaymentCalculator.Model;

namespace PaymentCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var employeesList = new List<Employee>();
            var outsourcedsList = new List<Outsourced>();

            Console.WriteLine("Quantos cadastros/consulta pretende realizar? ");
            int cadastros = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cadastros; i++)
            {
                Console.WriteLine("Outsourced (y/n): ");
                string colab = Console.ReadLine();

                if (colab == "n")
                {
                    var employeeController = new Controller.EmployeeController();
                    employeeController.Run(employeesList);
                }
                else
                {
                    var outsourcedController = new Controller.OutsourcedController();
                    outsourcedController.Run(outsourcedsList);
                }
            }

            var paymentController = new Controller.PaymentController();
            paymentController.Run(employeesList,outsourcedsList);

            var fileController = new Controller.FileController();
            fileController.Run(employeesList,outsourcedsList);
        }
    }
}
