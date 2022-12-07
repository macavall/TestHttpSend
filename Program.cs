using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SendURLRequest
{
    internal class Program
    {
        static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            string url1 = "https://oryx-cdn.microsoft.io/";
            string url2 = "https://TimerSendRESTFA561.azurewebsites.net/";

            var result = await client.GetAsync(url1);
            var result2 = await client.GetAsync(url2);

            Console.WriteLine("Result for " + url1 + ": " + result.StatusCode);
            Console.WriteLine("Result for " + url2 + ": " + result2.StatusCode);
            Console.ReadLine();
        }
    }
}
