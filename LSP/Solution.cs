using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCP
{
    public class Solution
    {

        public abstract class Veículo
        {
            void Mover()
            {
                Console.WriteLine("Movendo");
            }

            void Parar()
            {
                Console.WriteLine("Parando");
            }

            void LigarMotor()
            {
                Console.WriteLine("Ligando o motor.");
            }
            void DesligarMotor()
            {
                Console.WriteLine("Desligando o motor.");
            }

        }
        public class Carro : Veículo
        {
            public void LigarMotor() {}
            public void Mover() {}
            public void Parar() {}
            public void DesligarMotor() { }
        }

        public class Bicicleta : Veículo
        {
            public void Mover() {}
            public void Parar() {}

        }


    }
}
