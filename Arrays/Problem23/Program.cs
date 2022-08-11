namespace Problem23
{
    internal class Program
    {
        public static int n;

        static void Main(string[] args)
        {
            /*
             Write a program, which reads the integer numbers N and K from the
             console and prints all variations of K elements of the numbers in the
             interval [1…N]. Test
             */

            n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] array = new int[k];

            Rect(0, array);
        }

        public static void Rect(int index, int[] array)
        {
            if (index != array.Length)
            {
                for (int i = 1; i <= n; i++)
                {
                    array[index] = i;
                    Rect(index + 1, array);
                }
            }
            else
            {
                Console.WriteLine(String.Join(", ", array));
            }
        }
    }
}