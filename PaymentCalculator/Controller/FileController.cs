using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaymentCalculator.Model;

namespace PaymentCalculator.Controller
{
    using Model;
    public class FileController
    {
        public void Run(List<Employee> employees, List<Outsourced> outsourced)
        {
            Console.WriteLine("Write a file with the given information? (y/n)");
            string confirmation = Console.ReadLine();

            if (confirmation == "y")
            {
                Console.WriteLine("File name:");
                string file = Console.ReadLine();

                string filePath = Path.Combine(@"C:\Users\User\source\programmers\PaymentCalculator\Files\", file + ".xml");

                EmployeesData data = new EmployeesData();
                data.Employees = employees;
                data.Outsourced = outsourced;

                SerializeToXml(data, filePath);
                Console.WriteLine($"File create sucessed: {filePath}");

            }

            Console.WriteLine("Press any key to exit ...");
            Console.ReadLine();    
           
        }
        private void SerializeToXml(EmployeesData data, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(EmployeesData));
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, data);
            }
        }

    }

    public class EmployeesData
    {
        public List<Employee> Employees { get; set; }
        public List<Outsourced> Outsourced { get; set; }
    }
    
}
