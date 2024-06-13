using System;
using System.Collections.Generic;
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


		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}


		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private int hours;

		public int Hours
		{
			get { return hours; }
			set { hours = value; }
		}

		private double valuePerHour;

		public double ValuePerHour
		{
			get { return valuePerHour; }
			set { valuePerHour = value; }
		}

		private double payment;

		public double Payment
		{
			get { return CalcPayment(); }
		}

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
