namespace Problem7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Write a recursive program, which generates and prints all permutations
             of the numbers 1, 2, …, n, for a given integer n.

             Example input: n = 3;
             Example output: (1, 2, 3), (1, 3, 2), (2, 1, 3), (2, 3, 1), (3, 1, 2), (3, 2, 1)
             */

            int n = int.Parse(Console.ReadLine());

            int[] array = Enumerable.Range(1, n).ToArray();

            Permutation(0, n - 1, array);
         }

        static void Permutation(int start, int end, int[] array)
        {
            if (start == end)
            {
                Console.WriteLine(String.Join(", ", array));
                return;
            }

            for (int i = start; i <= end; i++)
            {
                (array[start], array[i]) = (array[i], array[start]);

                Permutation(start + 1, end, array);

                (array[start], array[i]) = (array[i], array[start]);
            }

        }
    }
}