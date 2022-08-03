namespace Problem13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string binaryNum = Console.ReadLine();

            double result = 0;

            for (int i = 0; i < binaryNum.Length; i++)
            {
                int toThePowerOf = binaryNum.Length - i - 1;

                result += char.GetNumericValue(binaryNum[i]) * Math.Pow(2, toThePowerOf);
            }

            Console.WriteLine(result);
        }
    }
}