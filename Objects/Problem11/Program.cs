namespace Problem11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter product:");
            string product = Console.ReadLine();

            AdvertismentMaker advertismentMaker = new AdvertismentMaker(product);

            Console.WriteLine(advertismentMaker.MakeAdvert());
            Console.WriteLine(advertismentMaker.MakeAdvert());
        }
    }
}