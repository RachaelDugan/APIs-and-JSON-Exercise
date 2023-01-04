using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    internal class QuoteGenClass
    {
        private HttpClient _client;

        public QuoteGenClass(HttpClient client)
        {
            
            _client = client;
        }
        public string KanyeQuote()
        {
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest";
            var kanyeResponse = _client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            return kanyeQuote;
        }
        public string NameRedactedQuote()
        {
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronResponse = _client.GetStringAsync(ronURL).Result;
            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
            return ronQuote;
        }
    }
}
