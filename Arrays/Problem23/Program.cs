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

            int[] result = Enumerable.Repeat(1, k).ToArray();
            HashSet<string> set = new HashSet<string>();

            set.Add(Stringify(result));

            for (int i = k - 1; i > 0; i--)
            {
                set = IterateElements(set, result, i, n);
            }

            PrintSet(set);
        }

        public static void PrintSet(HashSet<string> set)
        {
            foreach (string result in set)
            {
                Console.WriteLine($"{{{result}}}");
            }
        }

        public static HashSet<string> IterateElements(HashSet<string> set, int[] result, int i, int n)
        {

            for (int j = 1; j < n; j++)
            {
                result[i]++;
                set.Add(Stringify(result));
            }

            if (result[i - 1] < n)
            {
                result[i - 1]++;
                result[i] = 1;

                set.Add(Stringify(result));

                set = IterateElements(set, result, i, n);
            }

            result[i - 1] = 1;
            result[i] = 1;

            return set;
        }

        public static string Stringify(int[] result)
        {
            return String.Join(", ", result);
        }
    }
}