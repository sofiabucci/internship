using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCP
{
    public class Problem
    {
        public class Veiculo
        {
            public virtual void LigarMotor()
            {
                Console.WriteLine("Ligando o motor.");
            }
        }

        public class Carro : Veiculo
        {
            public override void LigarMotor() { }

        }

        public class Bicicleta : Veiculo
        {
            public override void LigarMotor() { }

        }


    }
}
