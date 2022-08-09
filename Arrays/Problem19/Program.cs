namespace Problem19
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
               Write a program, which finds all prime numbers in the range
               [1 … 1,000,000].
             */

            const int max = 100000;

            bool[] primes = new bool[max];
            primes = Array.ConvertAll(primes, prime => prime = true);


            // Using "The sieve of Erathostenes"
            for (int i = 2; i < Math.Sqrt(max); i++)
            {
                if (primes[i])
                {
                    for (int j = (int)Math.Pow(i, 2); j < max; j += i)
                    {
                        primes[j] = false;
                    }
                }
            }

            // PrintResult(primes);
        }

        // Added just for testing
        public static void PrintResult(bool[] primes)
        {
            List<int> result = new List<int>();

            for (int i = 2; i < primes.Length; i++)
            {
                if (primes[i])
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(String.Join(", ", result));
        }
    }
}