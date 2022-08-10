namespace Problem16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            Random random = new Random();

            for (int i = 1; i <= n; i++)
            {
                array[i] = i;
            }

            int[] randomisedArray = array
                .OrderBy(x => random.Next())
                .ToArray();

            PrintArray(array);
        }

        public static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
    }
}