using System.Net;

namespace Problem13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program to download a file from Internet by given URL

            string url = Console.ReadLine();
            string[] fileName = url.Split("/");

            using (WebClient web = new WebClient())
            {
                try
                {
                    web.DownloadFile(url, fileName[fileName.Length - 1]);
                }
                catch (ArgumentNullException argnulle)
                {
                    Console.WriteLine(argnulle.Message);
                }
                catch (WebException webe)
                {
                    Console.WriteLine(webe.Message);
                }
                
            }
           
        }
    }
}