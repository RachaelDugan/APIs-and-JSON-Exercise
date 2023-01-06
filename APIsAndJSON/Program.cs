using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region quote
            //var client = new HttpClient();
            //var quote = new QuoteGenClass(client);

            //Console.WriteLine("A Conversation Between Two Very Different People");
            //Console.WriteLine("------------------------------------------------");

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine($"Ye:    {quote.KanyeQuote()}");
            //    Console.WriteLine();
            //    Console.WriteLine($"NAME REDACTED:    {quote.NameRedactedQuote()}");
            //    Console.WriteLine();
            //}
             #endregion
            var client = new HttpClient();

            //Console.WriteLine("Enter your key:");
            var key = "e3e5918838b9ebb1a858a44aadd9b151";
            //var city = "Birmingham";
            //Console.WriteLine("Enter the city to get the forcast for today:");
            //var city = Console.ReadLine();

            //Console.WriteLine(response);


            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Enter a city name to get the current tempurature conditions: ");
                var city = Console.ReadLine();
                Console.WriteLine();
                var weatherURL = $"https://api.openweathermap.org/data/2.5/forecast?q={city}&appid={key}&units=imperial";
                var response = client.GetStringAsync(weatherURL).Result;
                JObject formattedResponse = JObject.Parse(response);
                var temp = formattedResponse["list"][0]["main"]["temp"];
                var feelsLike = formattedResponse["list"][0]["main"]["feels_like"];
                var humidity = formattedResponse["list"][0]["main"]["humidity"];
                Console.WriteLine($"The current tempurature is: {temp}");
                Console.WriteLine($"Feels like: {feelsLike}");
                Console.WriteLine($"Humidity is: {humidity}");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Would you like to inquire about another city?");
                var goAgain = Console.ReadLine();
                Console.WriteLine();

                if (goAgain.ToLower().Trim() == "no")
                {
                    break;
                }
            }
        }
    }
}
