namespace Problem13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string binaryNum = Console.ReadLine();

            double result = 0;

            /*
             * Take binary number from left to right
             * multiply it by 2 to the power of its position from right to left
             * add results together
             * 
             * 1011 = 1 * 2^3 + 0 * 2^2 + 1 * 2^1 + 1 * 2^0
             */


            for (int i = 0; i < binaryNum.Length; i++)
            {
                int toThePowerOf = binaryNum.Length - i - 1;

                result += char.GetNumericValue(binaryNum[i]) * Math.Pow(2, toThePowerOf);
            }

            Console.WriteLine(result);
        }
    }
}