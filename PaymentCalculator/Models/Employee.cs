using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PaymentCalculator.Model
{
    public class Employee
    {
		public Employee()
		{
			Name = "";
			Id = 0;
			Hours = 0;
			ValuePerHour = 0;
		}


        public int Id { get; private set; }


		public string Name { get; private set; }

		public int Hours { get; private set; }

		private double ValuePerHour { get; private set; }

		
		public double Payment { get { return CalcPayment(); } }
		

		protected virtual double CalcPayment()
		{
			return (Hours * ValuePerHour);
		}
		
		public void ShowNamePayment()
		{
			Console.WriteLine($"{this.Name} - $ {this.Payment}");
		}

    }
}
