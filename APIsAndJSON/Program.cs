using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
           var client = new HttpClient();
           var quote = new QuoteGenClass(client);
            Console.WriteLine("A Conversation Between Two Very Different People");
            Console.WriteLine("------------------------------------------------");
            for (int i = 0; i < 5; i++)
                {
                Console.WriteLine();
                Console.WriteLine($"Ye:    {quote.KanyeQuote()}");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"NAME REDACTED:    {quote.NameRedactedQuote()}");
                Console.WriteLine();
                }
           
        }
    }
}
