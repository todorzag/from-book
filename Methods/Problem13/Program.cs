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

            string input = Console.ReadLine();

            string[] polynomialsString = input.Split(
                new string[] { "(", ")" },
                StringSplitOptions.RemoveEmptyEntries);

            List<int[]> ints = PolynomialsToArray(polynomialsString);

            int[] polynomial1 = ints[0];
            int[] polynomial2 = ints[1];

            int max = Math.Max(
                polynomial1.Length,   
                polynomial2.Length);

            int[] sum = new int[max];

            CalculateSum(sum, polynomial1);
            CalculateSum(sum, polynomial2);

            Console.WriteLine(ReturnPolynomialString(sum));
        }

        public static List<int[]> PolynomialsToArray(string[] polynomials)
        {
            List<int[]> listOfPolynomialsArray = new List<int[]>
            {
                GetIndividual(polynomials[0]),
                GetIndividual(polynomials[2])
            };

            return listOfPolynomialsArray;
        }

        public static int[] GetIndividual(string polynomial)
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

        public static void CalculateSum(int[] sum, int[] polynomial)
        {
            for (int i = 0; i < polynomial.Length; i++)
            {
                if (sum[i] == 0)
                {
                    sum[i] = polynomial[i];
                }
                else
                {
                    sum[i] += polynomial[i];
                }
            }
        }

        public static string ReturnPolynomialString(int[] polynomial)
        {
            StringBuilder result = new StringBuilder();

            for (int i = polynomial.Length - 1; i >= 0; i--)
            {
                if (polynomial[i] != 0)
                {
                    result.Append(ReturnIndividualString(polynomial, i));

                    result.Append(AddOperator(polynomial, i));

                }  
            }

            return $"({result})";
        }

        public static string ReturnIndividualString(int[] polynomial, int i)
        {
            if (polynomial[i] < 0)
            {
                polynomial[i] *= -1;
            }

            switch (i)
            {
                case 0:
                    return $"{polynomial[i]}";

                case 1:
                    return polynomial[i] == 1 
                        ? $"x"
                        : $"{polynomial[i]}x";

                default:
                    return polynomial[i] == 1
                        ? $"x{i}"  
                        : $"{polynomial[i]}x{i}";
            }
        }

        public static string AddOperator(int[] polynomial, int i)
        {
            if (i != 0)
            {
                if (polynomial[i - 1] > 0)
                {
                    return " + ";
                }
                else if (polynomial[i - 1] < 0)
                {
                    return " - ";
                }
            }

            return string.Empty;
        }
    }
}