using System.Text;
using System.Text.RegularExpressions;

namespace Problem26
{
    internal class Program
    {
        static string html = 
            @"<html>
                <head><title>News</title></head>
                <body><p><a href=http://softuni.org>Software
                    University</a>aims to provide free real-world practical
                    training for young people who want to turn into
                    skillful software engineers.</p></body>
            </html>";

        static void Main(string[] args)
        {
            /*
            Write a program that extracts all the text without any tags and
            attribute values from an HTML document.
            */

            Console.WriteLine(ExtractText(html));
        }

        static string ExtractText(string html)
        {
            html = Regex.Replace(html, "(<.*?>)", " ");

            string[] split = 
                html.Replace("\r\n"," ")
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            return String.Join(" ", split);
        }

    }
}