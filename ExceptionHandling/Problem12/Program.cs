namespace Problem12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();

            try
            {
                string text = File.ReadAllText(filePath);
                Console.WriteLine(text);
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch (PathTooLongException ptle)
            {
                Console.WriteLine(ptle.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine("IOException / Line 11");
            }

            
        }
    }
}