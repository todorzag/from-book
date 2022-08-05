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
            Console.WriteLine(ExtractText(html));
        }

        static string ExtractText(string html)
        {
            html = Regex.Replace(html, "(<.*?>)", String.Empty);

            return html;
        }

    }
}