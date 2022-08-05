using System.Text;

namespace Problem21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a program that extracts from a text all words which are
            palindromes, such as ABBA", "lamal", "exe".
            */

            string[] text = Console.ReadLine().Split(" ");

            StringBuilder result = new StringBuilder();

            foreach (string line in text)
            {
                string reversed = new string (line.ToCharArray().Reverse().ToArray());

                if (line.ToLower() == reversed.ToLower())
                {
                    result.Append(line);
                    result.Append(" ");
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}