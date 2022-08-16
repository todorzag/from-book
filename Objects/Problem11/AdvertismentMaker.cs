using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11
{
    internal class AdvertismentMaker
    {
        static string[] LaudatoryPhrases = new string[]
        {
            "{product} is excellent.",
            "{product} is a great product.",
            "I use {product} constantly.",
            "{product} is the best product from this category."
        };

        static string[] LaudatoryStories = new string[]
        {
            "Now I feel better.",
            "I managed to change.",
            "It made some miracle.",
            "I can’t believe it, but now I am feeling great.",
            "You should try it, too. I am very satisfied."
        };

        static string[] FirstNames = new string[]
        {
            "Dayan", "Stella", "Hellen", "Kate"
        };

        static string[] LastNames = new string[]
        {
            "Johnson", "Peterson", "Charls"
        };

        static string[] Cities = new string[]
        {
            "London", "Paris", "Berlin", "New York", "Madrid"
        };

        public string Product { get; }

        public AdvertismentMaker(string product)
        {
            Product = product;
        }

        public string MakeAdvert()
        {
            StringBuilder advert = new StringBuilder();

            Random rand = new Random();

            advert.Append(LaudatoryPhrases
                [rand.Next(LaudatoryPhrases.Length)] 
                + " ");

            advert.Replace("{product}", Product);

            advert.Append(LaudatoryStories
                [rand.Next(LaudatoryStories.Length)] 
                + " ");

            advert.Append("-- " + 
                FirstNames
                [rand.Next(FirstNames.Length)] 
                + " ");

            advert.Append(LastNames
                [rand.Next(LastNames.Length)]
                + ", ");

            advert.Append(Cities[rand.Next(Cities.Length)]);

            return advert.ToString();
        }
    }
}
