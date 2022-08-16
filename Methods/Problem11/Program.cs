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

            bool running = true;

            while (running)
            {
                PrintOptions(options);

                Console.WriteLine("Please enter option number:");
                string option = Console.ReadLine();
                bool isValidOption = ValidateOption(option, options);

                if (isValidOption)
                {
                    try
                    {
                        OptionHandler(option);
                        
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, no such option!");
                }

                running = AskTryAgain();
            }
        }

        public static void OptionHandler(string option)
        {
            switch (option)
            {
                case "1":
                    ReverseIntegarHandler();
                    break;

                case "2":
                    AverageOfSequenceHandler();
                    break;

                case "3":
                    LinearEquationHandler();
                    break;
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
            bool result = false;

            if (options.ContainsKey(option))
            {
                result = true;
            }

            return result;
        }

        public static void ReverseIntegarHandler()
        {
            Console.WriteLine("Please enter integar to reverse:");
            string integer = Console.ReadLine();

            ValidateIntegarRange(integer);

            string reversed = ReverseIntegarNumberOrder(integer);
            Console.WriteLine($"The reverse integar is {reversed}");
        }

        public static bool ValidateIntegarRange(string integar)
        {
            int n = int.Parse(integar);

            if (n < 1 || n > 50000000)
            {
                throw new ArgumentException("Must be in range 1 - 50,000,000!");
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

        public static void AverageOfSequenceHandler()
        {
            Console.WriteLine("Please enter sequence of numbers:");
            string sequence = Console.ReadLine();

            ValidateSequence(sequence);

            double average = CalculateAverageOfSequence(sequence);
            Console.WriteLine($"The average value is {average}");
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
                throw new ArgumentException("Sequence must not contain empty elements!");
            }

            return true;
        }

        public static void LinearEquationHandler()
        {
            Console.WriteLine("Please enter coefficient a:");
            int a = int.Parse(Console.ReadLine());

            ValidateCoefficient(a);

            Console.WriteLine("Please enter coefficient b:");
            int b = int.Parse(Console.ReadLine());

            double result = CalculateLinearEquation(a, b);
            Console.WriteLine($"The result is {result}");
        }

        public static double CalculateLinearEquation(int a, int b)
        {
            return b / a;
        }

        public static bool ValidateCoefficient(int a)
        {
            if (a == 0)
            {
                throw new ArgumentException("Invalid input 'a' must be a non-zero!");
            }

            return true;
        }

        public static bool AskTryAgain()
        {
            bool result = false;

            Console.WriteLine("Would you like to try again?");
            var answer = Console.ReadLine();

            if (answer == "Y")
            {
                Console.Clear();
                result = true;
            }

            return result;
        }
    }
}