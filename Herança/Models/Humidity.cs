using Herança.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança.Models
{
    public class Humidity : ISensor
    {

        public Humidity(double value)
        {
            Value = value;
        }

        public double Value { get; private set; }
        public double ReadValue()
        {
            return Value;
        }

        public string GetUnit()
        {
            return "Percent";
        }
    }
}
