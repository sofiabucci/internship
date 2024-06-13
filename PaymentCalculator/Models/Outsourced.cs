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

        private double addCharge;

        public double AddCharge
        {
            get { return addCharge; }
            set { addCharge = value; }
        }

        protected override double CalcPayment()
        {
            return (base.CalcPayment() + this.AddCharge)*1.16;
        }



    }
}
