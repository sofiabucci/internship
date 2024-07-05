using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("primos até o número : ");
            int n=Convert.ToInt32(Console.ReadLine());

            foreach (int PrimeNum in GetPrimeNum(1,n))
            {
                Console.WriteLine(PrimeNum);
            }

            Console.WriteLine("to finish press any key...");
            Console.ReadLine();

        }

        public static IEnumerable<int> GetPrimeNum(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    yield return i;
                }
            }
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }


    }
}
