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
            while (true)
            {
                if (n == 1)
                {
                    break;
                }

                fact *= n;
                n--;
            }

            return fact;
        }

        public static int GetNumberOfZerosAtEnd(int factoriel)
        {
            string factorielString = factoriel.ToString();
            int counter = 0;

            for (int x = factorielString.Length; x > 0; x--)
            {
                if (factorielString[x - 1] == '0')
                {
                    counter++;
                }

                if (factorielString[x - 1] != '1')
                {
                    return counter;
                }
            }

            return counter;
        }
    }
}