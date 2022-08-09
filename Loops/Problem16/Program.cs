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
                int index = GetRandomIndex(array);
                array[index] = i;
            }

            PrintArray(array);
        }

        public static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }

        public static int GetRandomIndex(int[] array)
        {
            Random random = new Random();

            int index = random.Next(0, array.Length);

            if (array[index] != 0)
            {
                index = GetRandomIndex(array);
            }

            return index;
        }
    }
}