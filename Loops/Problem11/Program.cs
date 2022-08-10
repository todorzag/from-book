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
            int counter = 0;

            for (int x = factorielString.Length - 1; x > 0; x--)
            {
                if (factorielString[x] == '0')
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }

            return counter;
        }
    }
}