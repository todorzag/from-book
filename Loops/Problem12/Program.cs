namespace Problem12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quotient = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            while (quotient != 0)
            {
                int remainder = quotient % 2;
                quotient /= 2;
                stack.Push(remainder);
            }

            foreach (int i in stack)
            {
                Console.Write(i);
            }
        }
    }
}