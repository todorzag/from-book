using System.Text;

namespace Problem13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              Write a method that calculates the sum of two polynomials with integer
              coefficients, for example: (3x2 + x - 3) + (x - 1) = (3x2 + 2x - 4).
             */
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            int[] polynomial1 = GetCoefficients(input1);
            int[] polynomial2 = GetCoefficients(input2);

            int[] sum = CalculateSum(polynomial1, polynomial2);

            Console.WriteLine($"{input1} + {input2} = {PrintPolynomial(sum)}");
        }

        public static int[] GetCoefficients(string polynomial)
        {
            string[] individual = polynomial.Split(" ");

            List<int> ints = new List<int>();

            for (int i = individual.Length - 1; i >= 0; i--)
            {
                if (int.TryParse(individual[i], out int n))
                {
                    ints.Add(n);
                }
                else if (individual[i] == "-")
                {
                    ints[ints.Count - 1] *= -1;
                }
                else if (individual[i] == "x")
                {
                    ints.Add(1);
                }
                else if (individual[i] != "+")
                {
                    ints.Add((int)char.GetNumericValue(individual[i][0]));
                }
            }

            return ints.ToArray();
        }

        public static int[] CalculateSum(int[] polynomial1, int[] polynomial2)
        {
            int max = Math.Max(
                polynomial1.Length,
                polynomial2.Length);

            int[] sum = new int[max];

            for (int i = 0; i < polynomial1.Length; i++)
            {
                sum[i] += polynomial1[i];
            }

            for (int i = 0; i < polynomial2.Length; i++)
            {
                sum[i] += polynomial2[i];
            }

            return sum;
        }

        public static string PrintPolynomial(int[] polynomial)
        {
            StringBuilder result = new StringBuilder();

            for (int i = polynomial.Length - 1; i >= 0; i--)
            {
                if (polynomial[i] < 0)
                {
                    polynomial[i] *= -1;
                    result.Append(" - ");
                }
                else if (polynomial[i] > 0) 
                {
                    result.Append(" + ");
                }

                if (polynomial[i] != 0)
                {
                    result.Append($"{polynomial[i]}x{i}");
                }  
            }

            return $"({result})";
        }
    }
}