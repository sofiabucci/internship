using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PaymentCalculator.Model
{
    public class Outsourced : Employee
    {
        public Outsourced()
        {
            AddCharge = 0;
        }

        public double AddCharge { get; private set; }
      

        protected override double CalcPayment()
        {
            return (base.CalcPayment() + this.AddCharge)*1.16;
        }



    }
}
