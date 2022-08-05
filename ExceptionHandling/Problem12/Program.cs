namespace Problem12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a program that gets from the user the full path to a file (for
            example C:\Windows\win.ini), reads the content of the file and prints it
            to the console. Find in MSDN how to us the System.IO.File.
            ReadAllText(…) method. Make sure all possible exceptions will be
            caught and a user-friendly message will be printed on the console.
            */

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