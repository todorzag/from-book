namespace Problem16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = i + 1;
            }

            for (int i = 0; i < array.Length / 2; i++)
            {
                int index1 = random.Next(array.Length);

                int temp = array[index1];
                array[index1] = array[i];
                array[i] = temp;
            }

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
    }
}