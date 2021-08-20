using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            swaggerClient client = new("https://localhost:44320", new HttpClient());

            var records = await client.WeatherForecastAsync();

            foreach (var rec in records)
            {
                Console.WriteLine(rec.Summary);
            }
        }
    }
}
