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

            string option = ReturnChosenOption();

            switch (option)
            {
                case "1":
                    string reversed = ReverseIntegarNumberOrder();
                    Console.WriteLine($"The reverse integar is {reversed}");
                    break;

                case "2":
                    double average = CalculateAverageOfSequence();
                    Console.WriteLine($"The average value is {average}");
                    break;

                case "3":
                    double result = LinearEquation();
                    Console.WriteLine($"The result is {result}");
                    break;

            }
        }

        public static string ReturnChosenOption()
        {
            Console.WriteLine("Option 1: Put the digits from an integer number into a reversed order.");
            Console.WriteLine("Option 2: Calculate the average of given sequence of numbers.");
            Console.WriteLine("Option 3: Solve the linear equation a * x + b = 0");

            Console.WriteLine("Please enter option number:");

            string option = ValidateOption(Console.ReadLine());

            return option;
        }

        public static string ValidateOption(string option)
        {
     
            string[] acceptable = new string[3]
            {
                "1",
                "2",
                "3"
            };

            if (!acceptable.Contains(option))
            {
                Console.WriteLine("Invalid option!");

                Console.WriteLine("Please enter option number:");

                option = Console.ReadLine();

                option = ValidateOption(option);
            }

            return option;
        }

        public static string ReverseIntegarNumberOrder()
        {
            string integar = ValidateIntegarRange();

            return new string 
                (integar
                .ToCharArray()
                .Reverse()
                .ToArray());
        }

        public static string ValidateIntegarRange()
        {
            Console.WriteLine("Please enter integar to reverse:");
            string integar = Console.ReadLine();

            int n = int.Parse(integar);

            if (!(1 <= n && n <= 50000000))
            {
                Console.WriteLine("Integar not in correct Range!");
                integar = ValidateIntegarRange();
            }

            return integar;

        }

        // If input is directly an array validate's if(array.Lenght == 0)
        public static double CalculateAverageOfSequence()
        {
            string sequence = ValidateSequence(); ;

            int[] sequenceArray = Array.ConvertAll(sequence.Split(","), el => int.Parse(el));

            return sequenceArray.Average();
        }

        public static string ValidateSequence()
        {
            Console.WriteLine("Please enter sequence of numbers:");
            string sequence = Console.ReadLine();

            string[] split = sequence.Split(",");

            if (split.Contains(" "))
            {
                Console.WriteLine("Sequence contains empty elements!");
                sequence = ValidateSequence();
            }

            return sequence;
        }

        public static double LinearEquation()
        {    
            double a = ValidateCoefficient();

            Console.WriteLine("Please enter coefficient b:");
            double b = int.Parse(Console.ReadLine());

            return b / a;
        }

        public static double ValidateCoefficient()
        {
            Console.WriteLine("Please enter coefficient a:");
            double a = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Invalid input 'a' must be a non-zero!");
                a = ValidateCoefficient();
            }

            return a;
        }
    }
}