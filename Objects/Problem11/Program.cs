namespace Problem11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a program, which generates a random advertising message for
            some product. The message has to consist of laudatory phrase, followed
            by a laudatory story, followed by author (first and last name) and city,
            which are selected from predefined lists.
            */

            Console.WriteLine("Please enter product:");
            string product = Console.ReadLine();

            AdvertismentMaker advertismentMaker = new AdvertismentMaker(product);

            Console.WriteLine(advertismentMaker.MakeAdvert());
            Console.WriteLine(advertismentMaker.MakeAdvert());
        }
    }
}