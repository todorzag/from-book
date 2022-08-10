namespace Problem14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quotient = int.Parse(Console.ReadLine());

            Stack<char> result = new Stack<char>();

            while (quotient != 0)
            {
                int remainder = quotient % 16;
                quotient /= 16;

                if (remainder >= 10)
                {
                    // + 55 because of ascii conversion
                    char letter = (char)(remainder + 55);
                    result.Push(letter);
                }
                else
                {
                    // + 48 because of ascii conversion
                    result.Push((char)(remainder + 48));
                }
            }

            foreach (char item in result)
            {
                Console.Write(item);
            }
        }
    }
}