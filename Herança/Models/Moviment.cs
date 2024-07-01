using Herança.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança.Models
{
    public class Moviment : ISensor
    {

        public Moviment(double value)
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
            return "Meters per second";
        }
    }
}
