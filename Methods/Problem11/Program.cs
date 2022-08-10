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

            List<string> options = new List<string>
            {
                "Option 1: Put the digits from an integer number into a reversed order.",
                "Option 2: Calculate the average of given sequence of numbers.",
                "Option 3: Solve the linear equation a * x + b = 0"

            };

            foreach (string line in options)
            {
                Console.WriteLine(line);
            }

            bool validation = false;
            int option = 0;

            while (!validation)
            {
                Console.WriteLine("Please enter option number:");
                option = int.Parse(Console.ReadLine());

                validation = ValidateOption(option, options.Count);
            }

            switch (option)
            {
                case 1:
                    string reversed = ReverseIntegarNumberOrder();
                    Console.WriteLine($"The reverse integar is {reversed}");
                    break;

                case 2:
                    double average = CalculateAverageOfSequence();
                    Console.WriteLine($"The average value is {average}");
                    break;

                case 3:
                    double result = LinearEquation();
                    Console.WriteLine($"The result is {result}");
                    break;

            }
        }

        public static bool ValidateOption(int option, int acceptable)
        {
            if (option < 1 || option > acceptable)
            {
                Console.WriteLine("Invalid option!");
                return false;
            }

            return true;
        }

        public static string ReverseIntegarNumberOrder()
        {
            bool validation = false;
            string integer = string.Empty;

            while (!validation)
            {
                Console.WriteLine("Please enter integar to reverse:");
                integer = Console.ReadLine();

                validation = ValidateIntegarRange(integer);
            }

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
                Console.WriteLine("Integar not in correct Range!");
                return false;
            }

            return true;

        }

        // If input is directly an array validate's if (array.Lenght == 0)
        public static double CalculateAverageOfSequence()
        {
            bool validation = false;
            string sequence = string.Empty;

            while (!validation)
            {
                Console.WriteLine("Please enter sequence of numbers:");
                sequence = Console.ReadLine();

                validation = ValidateSequence(sequence);
            }

            int[] sequenceArray = Array.ConvertAll(sequence.Split(","), el => int.Parse(el));

            return sequenceArray.Average();
        }

        public static bool ValidateSequence(string sequence)
        {
            string[] split = sequence.Split(",");

            if (split.Contains(" "))
            {
                Console.WriteLine("Sequence contains empty elements!");
                return false;
            }

            return true;
        }

        public static double LinearEquation()
        {
            bool validation = false;
            int a = 0;

            while (!validation)
            {
                Console.WriteLine("Please enter coefficient a:");
                a = int.Parse(Console.ReadLine());

                validation = ValidateCoefficient(a);
            }
            

            Console.WriteLine("Please enter coefficient b:");
            int b = int.Parse(Console.ReadLine());

            return b / a;
        }

        public static bool ValidateCoefficient(int a)
        {
            if (a == 0)
            {
                Console.WriteLine("Invalid input 'a' must be a non-zero!");
                return false;
            }

            return true;
        }
    }
}