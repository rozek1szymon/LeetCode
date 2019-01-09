using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodeAndDecodeTinyURL
{
    public class Codec
    {

        // Encodes a URL to a shortened URL
        public string encode(string longUrl)
        {

            return "a";
        }

        // Decodes a shortened URL to its original URL.
        public string decode(string shortUrl)
        {
            var coded = shortUrl.Split('/').ToList();
            foreach(string i in coded)
            {
                Console.WriteLine(i);
            }
            return "a";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Codec codec = new Codec();
            codec.decode("https://leetcode.com/problems/design-tinyurl");

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
