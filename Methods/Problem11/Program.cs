namespace Problem11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              Write a program that solves the following tasks:
              
              - Put the digits from an integer number into a reversed order.
              - Calculate the average of given sequence of numbers.
              - Solve the linear equation a * x + b = 0.

              Create appropriate methods for each of the above tasks.
              Make the program show a text menu to the user. By choosing an option
              of that menu, the user will be able to choose which task to be invoked.

              Perform validation of the input data:
              - The integer number must be a positive in the range [1…50,000,000].
              - The sequence of numbers cannot be empty.
              - The coefficient a must be non-zero.
             */

            Dictionary<string, string> options = new Dictionary<string, string>
            {
                {"1", "Option 1: Put the digits from an integer number into a reversed order."},
                {"2", "Option 2: Calculate the average of given sequence of numbers."},
                {"3", "Option 3: Solve the linear equation a * x + b = 0"}
            };

            Console.WriteLine("Please enter option number:");
            string option = Console.ReadLine();

            if (!ValidateOption(option, options))
            {
                Console.WriteLine("Invalid input, no such option!");
            }
            else
            {
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Please enter integar to reverse:");
                        string integer = Console.ReadLine();

                        if (ValidateIntegarRange(integer))
                        {
                            string reversed = ReverseIntegarNumberOrder(integer);
                            Console.WriteLine($"The reverse integar is {reversed}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input, integar not in range!");
                        }

                        break;

                    case "2":
                        Console.WriteLine("Please enter sequence of numbers:");
                        string sequence = Console.ReadLine();

                        if (ValidateSequence(sequence))
                        {
                            double average = CalculateAverageOfSequence(sequence);
                            Console.WriteLine($"The average value is {average}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input, Sequence must not contain empty elements!");
                        }

                        break;

                    case "3":
                        Console.WriteLine("Please enter coefficient a:");
                        int a = int.Parse(Console.ReadLine());

                        if (ValidateCoefficient(a))
                        {
                            Console.WriteLine("Please enter coefficient b:");
                            int b = int.Parse(Console.ReadLine());

                            double result = LinearEquation(a, b);
                            Console.WriteLine($"The result is {result}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input, 'a' must be a non-zero!");
                        }

                        break;
                }
            }
        }

        public static void PrintOptions(Dictionary<string, string> options)
        {
            foreach (var item in options)
            {
                Console.WriteLine(item.Value);
            }
        }

        public static bool ValidateOption
            (string option, Dictionary<string, string> options)
        {
            if (!options.ContainsKey(option))
            {
                return false;
            }

            return true;
        }

        public static string ReverseIntegarNumberOrder(string integer)
        {
            return new string
                (integer
                .ToCharArray()
                .Reverse()
                .ToArray());
        }

        public static bool ValidateIntegarRange(string integar)
        {
            int n = int.Parse(integar);

            if (n < 1 || n > 50000000)
            {
                return false;
            }

            return true;

        }

        // If input is directly an array validate's if (array.Lenght == 0)
        public static double CalculateAverageOfSequence(string sequence)
        {
            int[] sequenceArray = Array
                .ConvertAll(sequence.Split(","), el => int.Parse(el));

            return sequenceArray.Average();
        }

        public static bool ValidateSequence(string sequence)
        {
            string[] split = sequence.Split(",");

            if (split.Contains(" "))
            {
                return false;
            }

            return true;
        }

        public static double LinearEquation(int a, int b)
        {
            return b / a;
        }

        public static bool ValidateCoefficient(int a)
        {
            if (a == 0)
            {
                return false;
            }

            return true;
        }
    }
}