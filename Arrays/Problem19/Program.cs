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
        }
    }
}