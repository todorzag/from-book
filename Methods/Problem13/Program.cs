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

            Console.WriteLine($"{input1} + {input2} = ({PrintPolynomial(sum)})");
        }

        public static int[] GetCoefficients(string polynomial)
        {
            string[] split = polynomial.Split(new char[] { ' ','(',')' }, 
                StringSplitOptions.RemoveEmptyEntries);

            List<int> ints = new List<int>();

            for (int i = split.Length - 1; i >= 0; i--)
            {
                if (int.TryParse(split[i], out int n))
                {
                    ints.Add(n);
                }
                else if (split[i] == "-")
                {
                    ints[ints.Count - 1] *= -1;
                }
                else if (split[i] == "x")
                {
                    ints.Add(1);
                }
                else if (split[i] != "+")
                {
                    ints.Add((int)char.GetNumericValue(split[i][0]));
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
                if (i != polynomial.Length - 1)
                {
                    if (polynomial[i] < 0)
                    {
                        polynomial[i] *= -1;
                        result.Append(" - ");
                    }
                    else
                    {
                        result.Append(" + ");
                    }
                }

                if (polynomial[i] != 0)
                {
                    result.Append($"{polynomial[i]}x{i}");
                }
            }

            return result.ToString();
        }
    }
}