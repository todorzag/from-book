namespace Problem23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Write a program, which reads the integer numbers N and K from the
             console and prints all variations of K elements of the numbers in the
             interval [1…N]. Test
             */


            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] array = Enumerable.Repeat(1, k).ToArray();

            for (int i = n - 1; i > 0; i--)
            {
                if (i != n - 1)
                {
                    array[i - 1]++;
                }

                while (array[i - 1] <= n)
                {
                    Console.WriteLine(String.Join(", ", array));
                    array[i]++;

                    if (array[i] > n)
                    {
                        array[i] = 1;
                        array[i - 1]++;
                    }
                }

                array = Enumerable.Repeat(1, k).ToArray();
            }
        }
    }
}