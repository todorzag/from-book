namespace Problem14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quotient = int.Parse(Console.ReadLine());

            Stack<string> result = new Stack<string>();

            while (quotient != 0)
            {
                int remainder = quotient % 16;
                quotient /= 16;

                result.Push(CheckRemainder(remainder));
            }

            PrintResult(result);
        }

        public static string CheckRemainder(int remainder)
        {
            string result = remainder.ToString();

            Dictionary<int, string> moreThan10 = new Dictionary<int, string>
            {
                {10, "A"},
                {11, "B"},
                {12, "C"},
                {13, "D"},
                {14, "E"},
                {15, "F"},
            };

            if (moreThan10.ContainsKey(remainder))
            {
                result = moreThan10[remainder];
            }

            return result;
        }

        public static void PrintResult(Stack<string> result)
        {
            foreach (string item in result)
            {
                Console.Write(item);
            }
        }
    }
}