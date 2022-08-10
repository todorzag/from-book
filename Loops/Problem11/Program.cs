using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Problem11
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int factoriel = GetFactoriel(n);

            Console.WriteLine(factoriel);

            int result = GetNumberOfZerosAtEnd(factoriel);
            Console.WriteLine(result);
        }

        public static int GetFactoriel(int n)
        {
            int fact = 1;
            while (n != 1)
            {
                fact *= n;
                n--;
            }

            return fact;
        }

        public static int GetNumberOfZerosAtEnd(int factoriel)
        {
            string factorielString = factoriel.ToString();
            string withoutZeros = factorielString.TrimEnd('0');

            return factorielString.Length - withoutZeros.Length;
        }
    }
}