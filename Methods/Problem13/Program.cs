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

            string[] polynomialsString = input.Split(new string[] { "(", ")" }, StringSplitOptions.RemoveEmptyEntries);

            List<int[]> ints = PolynomialsToArray(polynomialsString);

            int[] sum = CalculateSum(ints);

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

        public static int[] CalculateSum(List<int[]> ints)
        {
            int[] polynomial1 = ints[0];
            int[] polynomial2 = ints[1];

            int max = Math.Max(polynomial1.Length, polynomial2.Length);
            int[] sum = new int[max];

            for (int i = 0; i < polynomial1.Length; i++)
            {
                sum[i] = polynomial1[i];
            }

            for (int i = 0; i < polynomial2.Length; i++)
            {
                sum[i] += polynomial2[i];
            }

            return sum;
        }

        public static string ReturnPolynomialString(int[] polynomial)
        {
            string result = "";

            for (int i = polynomial.Length - 1; i >= 0; i--)
            {
                if (polynomial[i] != 0)
                {
                    result += ReturnIndividualString(polynomial, i);

                    if (i != 0)
                    {
                        if (polynomial[i - 1] > 0)
                        {
                            result += " + ";
                        }
                        else if (polynomial[i - 1] > 0)
                        {
                            result += " - ";
                        }
                    }
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

            if (i > 1)
            {
                if (polynomial[i] == 1)
                {
                    return $"x{i}";
                }
                else
                {
                    return $"{polynomial[i]}x{i}";
                }

            }
            else if (i == 1)
            {
                if (polynomial[i] == 1)
                {
                    return $"x";
                }
                else
                {
                    return $"{polynomial[i]}x";
                }
            }
            else
            {
                return $"{polynomial[i]}";
            }
        }
    }
}